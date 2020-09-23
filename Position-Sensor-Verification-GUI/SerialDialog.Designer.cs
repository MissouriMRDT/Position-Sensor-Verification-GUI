namespace Position_Sensor_Verification_GUI
{
    partial class SerialDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SerialConnect_pb = new System.Windows.Forms.Button();
            this.Port_cb = new System.Windows.Forms.ComboBox();
            this.RefreshSerial_pb = new System.Windows.Forms.Button();
            this.Parity_cb = new System.Windows.Forms.ComboBox();
            this.Baud_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StopBit_cb = new System.Windows.Forms.ComboBox();
            this.Bits_tb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Disconnect_pb = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialConnect_pb
            // 
            this.SerialConnect_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SerialConnect_pb.Location = new System.Drawing.Point(100, 3);
            this.SerialConnect_pb.Name = "SerialConnect_pb";
            this.SerialConnect_pb.Size = new System.Drawing.Size(91, 34);
            this.SerialConnect_pb.TabIndex = 0;
            this.SerialConnect_pb.Text = "Connect";
            this.SerialConnect_pb.UseVisualStyleBackColor = true;
            this.SerialConnect_pb.Click += new System.EventHandler(this.SerialConnect_pb_Click);
            // 
            // Port_cb
            // 
            this.Port_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Port_cb.FormattingEnabled = true;
            this.Port_cb.Location = new System.Drawing.Point(149, 3);
            this.Port_cb.Name = "Port_cb";
            this.Port_cb.Size = new System.Drawing.Size(140, 24);
            this.Port_cb.TabIndex = 1;
            // 
            // RefreshSerial_pb
            // 
            this.RefreshSerial_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshSerial_pb.Location = new System.Drawing.Point(3, 3);
            this.RefreshSerial_pb.Name = "RefreshSerial_pb";
            this.RefreshSerial_pb.Size = new System.Drawing.Size(91, 34);
            this.RefreshSerial_pb.TabIndex = 3;
            this.RefreshSerial_pb.Text = "Refresh";
            this.RefreshSerial_pb.UseVisualStyleBackColor = true;
            this.RefreshSerial_pb.Click += new System.EventHandler(this.RefreshSerial_pb_Click);
            // 
            // Parity_cb
            // 
            this.Parity_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parity_cb.FormattingEnabled = true;
            this.Parity_cb.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.Parity_cb.Location = new System.Drawing.Point(149, 69);
            this.Parity_cb.Name = "Parity_cb";
            this.Parity_cb.Size = new System.Drawing.Size(140, 24);
            this.Parity_cb.TabIndex = 10;
            // 
            // Baud_cb
            // 
            this.Baud_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Baud_cb.FormattingEnabled = true;
            this.Baud_cb.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000",
            "1000000",
            "2000000"});
            this.Baud_cb.Location = new System.Drawing.Point(149, 36);
            this.Baud_cb.Name = "Baud_cb";
            this.Baud_cb.Size = new System.Drawing.Size(140, 24);
            this.Baud_cb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "StopBit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bits";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StopBit_cb
            // 
            this.StopBit_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopBit_cb.FormattingEnabled = true;
            this.StopBit_cb.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.StopBit_cb.Location = new System.Drawing.Point(149, 135);
            this.StopBit_cb.Name = "StopBit_cb";
            this.StopBit_cb.Size = new System.Drawing.Size(140, 24);
            this.StopBit_cb.TabIndex = 11;
            // 
            // Bits_tb
            // 
            this.Bits_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bits_tb.Location = new System.Drawing.Point(149, 102);
            this.Bits_tb.Name = "Bits_tb";
            this.Bits_tb.Size = new System.Drawing.Size(140, 22);
            this.Bits_tb.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.3578F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.6422F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(298, 218);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Parity_cb, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.StopBit_cb, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Bits_tb, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.Baud_cb, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Port_cb, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 166);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.Disconnect_pb, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.SerialConnect_pb, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.RefreshSerial_pb, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 175);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(292, 40);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // Disconnect_pb
            // 
            this.Disconnect_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Disconnect_pb.Location = new System.Drawing.Point(197, 3);
            this.Disconnect_pb.Name = "Disconnect_pb";
            this.Disconnect_pb.Size = new System.Drawing.Size(92, 34);
            this.Disconnect_pb.TabIndex = 4;
            this.Disconnect_pb.Text = "Disconnect";
            this.Disconnect_pb.UseVisualStyleBackColor = true;
            this.Disconnect_pb.Click += new System.EventHandler(this.Disconnect_pb_Click);
            // 
            // SerialDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 218);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "SerialDialog";
            this.Text = "Serial";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SerialConnect_pb;
        private System.Windows.Forms.Button RefreshSerial_pb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox Port_cb;
        public System.Windows.Forms.ComboBox Baud_cb;
        public System.Windows.Forms.ComboBox Parity_cb;
        public System.Windows.Forms.ComboBox StopBit_cb;
        public System.Windows.Forms.TextBox Bits_tb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Disconnect_pb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

