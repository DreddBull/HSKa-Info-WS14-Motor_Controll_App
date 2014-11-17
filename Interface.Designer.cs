namespace Motor_Controll_App
{
    partial class Interface
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
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarTime = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelTimeValue = new System.Windows.Forms.Label();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verfahrzeit (in Minuten)";
            // 
            // trackBarTime
            // 
            this.trackBarTime.Location = new System.Drawing.Point(15, 112);
            this.trackBarTime.Maximum = 60;
            this.trackBarTime.Minimum = 1;
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(170, 45);
            this.trackBarTime.TabIndex = 4;
            this.trackBarTime.TickFrequency = 5;
            this.trackBarTime.Value = 30;
            this.trackBarTime.ValueChanged += new System.EventHandler(this.trackBarTime_valueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP-Adresse (Motor)";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(15, 26);
            this.textBoxIP.MaxLength = 15;
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(124, 20);
            this.textBoxIP.TabIndex = 1;
            this.textBoxIP.Text = "192.168.11.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(29, 168);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "Linksfahrt";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(110, 168);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Anhalten";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(191, 168);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 7;
            this.buttonRight.Text = "Rechtsfahrt";
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Motorbefehle (Textkommandos)";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(19, 222);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(257, 20);
            this.textBoxCommand.TabIndex = 8;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(15, 53);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(68, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Verbinden";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelTimeValue
            // 
            this.labelTimeValue.AutoSize = true;
            this.labelTimeValue.Location = new System.Drawing.Point(191, 112);
            this.labelTimeValue.Name = "labelTimeValue";
            this.labelTimeValue.Size = new System.Drawing.Size(38, 13);
            this.labelTimeValue.TabIndex = 12;
            this.labelTimeValue.Text = "30 min";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(162, 26);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownPort.TabIndex = 2;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.numericUpDownPort);
            this.Controls.Add(this.labelTimeValue);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarTime);
            this.Controls.Add(this.label1);
            this.Name = "Interface";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelTimeValue;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
    }
}

