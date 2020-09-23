using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Position_Sensor_Verification_GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            serial.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceive);

            if(!Directory.Exists(dataLog_path))
            {
                Directory.CreateDirectory(dataLog_path);
            }
        }

        private string dataLog_path = "dataLog/";
        private StreamWriter dataLog;

        private SerialPort serial = new SerialPort(" ", 115200, Parity.None, 8, StopBits.One);

        private string serialLine = "";
        private void serial_DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            serialLine = serialLine + serial.ReadExisting();

            if (serialLine[serialLine.Length-1] == '\n')
            {
                Console.Write(serialLine);
                if (logData.Checked)
                {
                    try
                    {
                        dataLog.Write(DateTime.Now.ToString("HH_mm_ss_ffff") + "," + serialLine);
                    }
                    catch { }
                }

                serialLine = "";

            }
            
        }

        private void closeSerial()
        {
            serial.Close();
        }

        private void openSerial()
        {
            serial.Open();
        }

        private void Serial_pb_Click(object sender, EventArgs e)
        {
            using (var serialDialog = new SerialDialog(serial))
            {
                var result = serialDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    closeSerial();

                    serial.PortName = serialDialog.Port_cb.Text;
                    serial.BaudRate = Convert.ToInt32(serialDialog.Baud_cb.Text);
                    serial.Parity = (Parity)Enum.Parse(typeof(Parity), serialDialog.Parity_cb.Text);
                    serial.DataBits = Convert.ToInt32(serialDialog.Bits_tb.Text);
                    serial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), serialDialog.StopBit_cb.Text);

                    openSerial();
                }
                if(result == DialogResult.Cancel)
                {
                    closeSerial();
                }
            }
        }

        private void logData_CheckedChanged(object sender, EventArgs e)
        {
            if(logData.Checked)
            {
                dataLog = new StreamWriter(dataLog_path + DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss_f") + ".txt");
            }
            else
            {
                dataLog.Close();
            }
        }
    }
}
