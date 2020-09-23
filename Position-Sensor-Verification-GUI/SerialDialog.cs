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


namespace Position_Sensor_Verification_GUI
{
    public partial class SerialDialog : Form
    {
        public SerialDialog(SerialPort serial)
        {
            InitializeComponent();

            Port_cb.Text = serial.PortName;
            Baud_cb.Text = serial.BaudRate.ToString();
            Parity_cb.Text = serial.Parity.ToString();
            Bits_tb.Text = serial.DataBits.ToString();
            StopBit_cb.Text = serial.StopBits.ToString();

            refreshSerialList();
        }

        

        private void SerialConnect_pb_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RefreshSerial_pb_Click(object sender, EventArgs e)
        {
            refreshSerialList();
        }

        private void refreshSerialList()
        {
            Port_cb.Items.Clear();
            Port_cb.Items.AddRange(SerialPort.GetPortNames());
            if (Port_cb.Items.Count >0) Port_cb.Text = Port_cb.Items[0].ToString();
        }

        private void Disconnect_pb_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
