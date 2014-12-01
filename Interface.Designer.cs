namespace Lexium_MDrive_Test_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
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
            this.buttonSlowRight = new System.Windows.Forms.Button();
            this.buttonFastLeft = new System.Windows.Forms.Button();
            this.buttonSlowLeft = new System.Windows.Forms.Button();
            this.buttonFastRight = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonMediumLeft = new System.Windows.Forms.Button();
            this.buttonMediumRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verfahrgeschwindigkeit (mm/min)";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(15, 110);
            this.trackBarSpeed.Margin = new System.Windows.Forms.Padding(5);
            this.trackBarSpeed.Maximum = 3000;
            this.trackBarSpeed.Minimum = 50;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(230, 45);
            this.trackBarSpeed.SmallChange = 10;
            this.trackBarSpeed.TabIndex = 4;
            this.trackBarSpeed.TickFrequency = 300;
            this.trackBarSpeed.Value = 50;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarTime_valueChanged);
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
            this.textBoxIP.Text = "192.168.33.1";
            this.textBoxIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIP_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MCode Port (Motor)";
            // 
            // buttonLeft
            // 
            this.buttonLeft.Enabled = false;
            this.buttonLeft.Location = new System.Drawing.Point(15, 165);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(125, 25);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "Linksfahrt";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.Enabled = false;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonStop.Location = new System.Drawing.Point(150, 165);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(50, 60);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stopp";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Enabled = false;
            this.buttonRight.Location = new System.Drawing.Point(210, 165);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(125, 25);
            this.buttonRight.TabIndex = 7;
            this.buttonRight.Text = "Rechtsfahrt";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Motorbefehle (MCode)";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Enabled = false;
            this.textBoxCommand.Location = new System.Drawing.Point(15, 275);
            this.textBoxCommand.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(320, 20);
            this.textBoxCommand.TabIndex = 8;
            this.textBoxCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCommand_KeyDown);
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
            this.labelTimeValue.Location = new System.Drawing.Point(255, 120);
            this.labelTimeValue.Margin = new System.Windows.Forms.Padding(5);
            this.labelTimeValue.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelTimeValue.Name = "labelTimeValue";
            this.labelTimeValue.Size = new System.Drawing.Size(80, 13);
            this.labelTimeValue.TabIndex = 12;
            this.labelTimeValue.Text = "50 mm/min";
            this.labelTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(150, 26);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownPort.TabIndex = 2;
            this.numericUpDownPort.Value = new decimal(new int[] {
            503,
            0,
            0,
            0});
            // 
            // buttonSlowRight
            // 
            this.buttonSlowRight.Enabled = false;
            this.buttonSlowRight.Location = new System.Drawing.Point(210, 200);
            this.buttonSlowRight.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSlowRight.Name = "buttonSlowRight";
            this.buttonSlowRight.Size = new System.Drawing.Size(35, 25);
            this.buttonSlowRight.TabIndex = 13;
            this.buttonSlowRight.Text = ">";
            this.buttonSlowRight.UseVisualStyleBackColor = true;
            this.buttonSlowRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSlowRight_MouseDown);
            this.buttonSlowRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // buttonFastLeft
            // 
            this.buttonFastLeft.Enabled = false;
            this.buttonFastLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonFastLeft.Location = new System.Drawing.Point(15, 200);
            this.buttonFastLeft.Margin = new System.Windows.Forms.Padding(5);
            this.buttonFastLeft.Name = "buttonFastLeft";
            this.buttonFastLeft.Size = new System.Drawing.Size(35, 25);
            this.buttonFastLeft.TabIndex = 13;
            this.buttonFastLeft.Text = "<<<";
            this.buttonFastLeft.UseVisualStyleBackColor = true;
            this.buttonFastLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFastLeft_MouseDown);
            this.buttonFastLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // buttonSlowLeft
            // 
            this.buttonSlowLeft.Enabled = false;
            this.buttonSlowLeft.Location = new System.Drawing.Point(105, 200);
            this.buttonSlowLeft.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSlowLeft.Name = "buttonSlowLeft";
            this.buttonSlowLeft.Size = new System.Drawing.Size(35, 25);
            this.buttonSlowLeft.TabIndex = 14;
            this.buttonSlowLeft.Text = "<";
            this.buttonSlowLeft.UseVisualStyleBackColor = true;
            this.buttonSlowLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSlowLeft_MouseDown);
            this.buttonSlowLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // buttonFastRight
            // 
            this.buttonFastRight.Enabled = false;
            this.buttonFastRight.Location = new System.Drawing.Point(300, 200);
            this.buttonFastRight.Margin = new System.Windows.Forms.Padding(5);
            this.buttonFastRight.Name = "buttonFastRight";
            this.buttonFastRight.Size = new System.Drawing.Size(35, 25);
            this.buttonFastRight.TabIndex = 15;
            this.buttonFastRight.Text = ">>>";
            this.buttonFastRight.UseVisualStyleBackColor = true;
            this.buttonFastRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFastRight_MouseDown);
            this.buttonFastRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 310);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(349, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.IsLink = true;
            this.toolStripLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(212, 17);
            this.toolStripLabel.Text = "HSKa - WS 14 | J. Bokemeyer, A. Zacher";
            this.toolStripLabel.Click += new System.EventHandler(this.toolStripLabel_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(23, 23);
            // 
            // buttonMediumLeft
            // 
            this.buttonMediumLeft.Enabled = false;
            this.buttonMediumLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMediumLeft.Location = new System.Drawing.Point(60, 200);
            this.buttonMediumLeft.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMediumLeft.Name = "buttonMediumLeft";
            this.buttonMediumLeft.Size = new System.Drawing.Size(35, 25);
            this.buttonMediumLeft.TabIndex = 18;
            this.buttonMediumLeft.Text = "<<";
            this.buttonMediumLeft.UseVisualStyleBackColor = true;
            this.buttonMediumLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMediumLeft_MouseDown);
            this.buttonMediumLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // buttonMediumRight
            // 
            this.buttonMediumRight.Enabled = false;
            this.buttonMediumRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMediumRight.Location = new System.Drawing.Point(255, 200);
            this.buttonMediumRight.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMediumRight.Name = "buttonMediumRight";
            this.buttonMediumRight.Size = new System.Drawing.Size(35, 25);
            this.buttonMediumRight.TabIndex = 19;
            this.buttonMediumRight.Text = ">>";
            this.buttonMediumRight.UseVisualStyleBackColor = true;
            this.buttonMediumRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMediumRight_MouseDown);
            this.buttonMediumRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 332);
            this.Controls.Add(this.buttonMediumRight);
            this.Controls.Add(this.buttonMediumLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonFastRight);
            this.Controls.Add(this.buttonSlowLeft);
            this.Controls.Add(this.buttonFastLeft);
            this.Controls.Add(this.buttonSlowRight);
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
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Interface";
            this.Text = "Test GUI Motorsteuerung";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarSpeed;
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
        private System.Windows.Forms.Button buttonSlowRight;
        private System.Windows.Forms.Button buttonFastLeft;
        private System.Windows.Forms.Button buttonSlowLeft;
        private System.Windows.Forms.Button buttonFastRight;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button buttonMediumLeft;
        private System.Windows.Forms.Button buttonMediumRight;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
    }
}

