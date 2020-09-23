namespace Position_Sensor_Verification_GUI
{
    partial class Main
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
            this.Serial_pb = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.logData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Serial_pb
            // 
            this.Serial_pb.Location = new System.Drawing.Point(252, 236);
            this.Serial_pb.Name = "Serial_pb";
            this.Serial_pb.Size = new System.Drawing.Size(75, 23);
            this.Serial_pb.TabIndex = 0;
            this.Serial_pb.Text = "Serial";
            this.Serial_pb.UseVisualStyleBackColor = true;
            this.Serial_pb.Click += new System.EventHandler(this.Serial_pb_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // logData
            // 
            this.logData.AutoSize = true;
            this.logData.Location = new System.Drawing.Point(443, 248);
            this.logData.Name = "logData";
            this.logData.Size = new System.Drawing.Size(79, 21);
            this.logData.TabIndex = 2;
            this.logData.Text = "logData";
            this.logData.UseVisualStyleBackColor = true;
            this.logData.CheckedChanged += new System.EventHandler(this.logData_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logData);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Serial_pb);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Serial_pb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox logData;
    }
}