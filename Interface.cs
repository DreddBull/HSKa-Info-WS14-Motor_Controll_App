using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motor_Controll_App
{
    public partial class Interface : Form
    {

        MotorControl myMotor;
        //Konstruktor
        public Interface() {
            InitializeComponent();
        }

        //Methoden für Button Clicks

        //Verbindungsknopf
        private void buttonConnect_Click(object sender, EventArgs e) {
            //Prüfen ob bereits ein Objekt erstellt wurde
            if (myMotor == null) {
                myMotor = new MotorControl();
            }
            myMotor.connect(textBoxIP.Text, Convert.ToInt32(numericUpDownPort.Value));
            buttonLeft.Enabled = true;
            buttonRight.Enabled = true;
            buttonStop.Enabled = true;
            textBoxCommand.Enabled = true;
        }
        //Linkslauf
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            myMotor.sendCommand("SL " + Convert.ToString(5000000000 / (int)trackBarTime.Value));
        }
        //Rechtslauf
        private void buttonRight_Click(object sender, EventArgs e)
        {
            myMotor.sendCommand("SL " + "-" + Convert.ToString(5000000000/(int)trackBarTime.Value));
        }
        //Halt
        private void buttonStop_Click(object sender, EventArgs e)
        {
            myMotor.sendCommand("SL " + "0");
        }
        
        private void trackBarTime_valueChanged(object sender, EventArgs e) {
            labelTimeValue.Text = Convert.ToString(trackBarTime.Value) + " min";
        }

        private void textBoxCommand_KeyDown(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                myMotor.sendCommand(textBoxCommand.Text);
                textBoxCommand.Clear();
            }
        }







    }
}
