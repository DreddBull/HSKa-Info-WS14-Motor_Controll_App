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

        private void buttonConnect_Click(object sender, EventArgs e) {
            //Prüfen ob bereits ein Objekt erstellt wurde
            if (myMotor == null) {
                myMotor = new MotorControl(textBoxIP.Text, Convert.ToInt32(numericUpDownPort.Value));
                myMotor.connect();
            } else {
                //Wenn Objekt vorhanden, dann Prüfen ob eine Verbindung besteht
                if (myMotor.IsConnected) {
                    myMotor.disconnect();
                }
                myMotor.RemoteIPstring = textBoxIP.Text;
                myMotor.RemotePort = Convert.ToInt32(numericUpDownPort.Value);
                myMotor.connect();
            }
        }

        private void trackBarTime_valueChanged(object sender, EventArgs e) {
            labelTimeValue.Text = Convert.ToString(trackBarTime.Value) + " min";
        }

    }
}
