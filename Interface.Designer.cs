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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // trackBarSpeed
            // 
            resources.ApplyResources(this.trackBarSpeed, "trackBarSpeed");
            this.trackBarSpeed.Maximum = 3000;
            this.trackBarSpeed.Minimum = 50;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.SmallChange = 10;
            this.trackBarSpeed.TickFrequency = 300;
            this.trackBarSpeed.Value = 50;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarTime_valueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxIP
            // 
            resources.ApplyResources(this.textBoxIP, "textBoxIP");
            this.textBoxIP.Name = "textBoxIP";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // buttonLeft
            // 
            resources.ApplyResources(this.buttonLeft, "buttonLeft");
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonRight
            // 
            resources.ApplyResources(this.buttonRight, "buttonRight");
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxCommand
            // 
            resources.ApplyResources(this.textBoxCommand, "textBoxCommand");
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCommand_KeyDown);
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelTimeValue
            // 
            resources.ApplyResources(this.labelTimeValue, "labelTimeValue");
            this.labelTimeValue.Name = "labelTimeValue";
            // 
            // numericUpDownPort
            // 
            resources.ApplyResources(this.numericUpDownPort, "numericUpDownPort");
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Value = new decimal(new int[] {
            503,
            0,
            0,
            0});
            this.numericUpDownPort.ValueChanged += new System.EventHandler(this.numericUpDownPort_ValueChanged);
            // 
            // buttonSlowRight
            // 
            resources.ApplyResources(this.buttonSlowRight, "buttonSlowRight");
            this.buttonSlowRight.Name = "buttonSlowRight";
            this.buttonSlowRight.UseVisualStyleBackColor = true;
            this.buttonSlowRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSlowRight_MouseDown);
            this.buttonSlowRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // buttonFastLeft
            // 
            resources.ApplyResources(this.buttonFastLeft, "buttonFastLeft");
            this.buttonFastLeft.Name = "buttonFastLeft";
            this.buttonFastLeft.UseVisualStyleBackColor = true;
            this.buttonFastLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFastLeft_MouseDown);
            this.buttonFastLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // buttonSlowLeft
            // 
            resources.ApplyResources(this.buttonSlowLeft, "buttonSlowLeft");
            this.buttonSlowLeft.Name = "buttonSlowLeft";
            this.buttonSlowLeft.UseVisualStyleBackColor = true;
            this.buttonSlowLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSlowLeft_MouseDown);
            this.buttonSlowLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // buttonFastRight
            // 
            resources.ApplyResources(this.buttonFastRight, "buttonFastRight");
            this.buttonFastRight.Name = "buttonFastRight";
            this.buttonFastRight.UseVisualStyleBackColor = true;
            this.buttonFastRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFastRight_MouseDown);
            this.buttonFastRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripStatusLabel1.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // buttonMediumLeft
            // 
            resources.ApplyResources(this.buttonMediumLeft, "buttonMediumLeft");
            this.buttonMediumLeft.Name = "buttonMediumLeft";
            this.buttonMediumLeft.UseVisualStyleBackColor = true;
            this.buttonMediumLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMediumLeft_MouseDown);
            this.buttonMediumLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // buttonMediumRight
            // 
            resources.ApplyResources(this.buttonMediumRight, "buttonMediumRight");
            this.buttonMediumRight.Name = "buttonMediumRight";
            this.buttonMediumRight.UseVisualStyleBackColor = true;
            this.buttonMediumRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMediumRight_MouseDown);
            this.buttonMediumRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Release);
            // 
            // Interface
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Interface";
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
    }
}

