using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lexium_MDrive_Test_GUI
{
    public partial class Interface : Form
    {
        //Variablen
        MotorControl myMotor;       //Objekt zum ansteuern des Motors
        uint speedFast = 4000;      //Geschwindigkeit in mm/min
        uint speedMedium = 1500;    //Geschwindigkeit in mm/min
        uint speedSlow = 100;       //Geschwindigkeit in mm/min
        
        //Konstruktor
        public Interface() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        //Buttons aktivieren
        private void enableButtons()
        {
            buttonLeft.Enabled = true;
            buttonRight.Enabled = true;
            buttonStop.Enabled = true;
            buttonSlowLeft.Enabled = true;
            buttonSlowRight.Enabled = true;
            buttonMediumLeft.Enabled = true;
            buttonMediumRight.Enabled = true;
            buttonFastLeft.Enabled = true;
            buttonFastRight.Enabled = true;
            textBoxCommand.Enabled = true;
        }

        //Buttons deaktivieren
        private void disableButtons()
        {
            buttonLeft.Enabled = false;
            buttonRight.Enabled = false;
            buttonStop.Enabled = false;
            buttonSlowLeft.Enabled = false;
            buttonSlowRight.Enabled = false;
            buttonMediumLeft.Enabled = false;
            buttonMediumRight.Enabled = false;
            buttonFastLeft.Enabled = false;
            buttonFastRight.Enabled = false;
            textBoxCommand.Enabled = false;
        }
        //Verbindung aufbauen
        private void connect() {
            disableButtons();
            //Prüfen ob bereits ein Objekt erstellt wurde
            if (myMotor == null)
            {
                myMotor = new MotorControl();
            }
            if (myMotor.connect(textBoxIP.Text, Convert.ToInt32(numericUpDownPort.Value)) == true)
            {
                enableButtons();
            }
            else
            {
                disableButtons();
            }
        }
        //Methoden für Events
        //Verbindungsknopf
        private void buttonConnect_Click(object sender, EventArgs e) {
                connect();
        }
        //Text-Box Eingabe
        private void textBoxIP_KeyDown(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                connect();
            }
        }

        //Linkslauf
        private void buttonLeft_Click(object sender, EventArgs e) {
            myMotor.driveLeft((uint)trackBarSpeed.Value);
        }

        //Rechtslauf
        private void buttonRight_Click(object sender, EventArgs e) {
            myMotor.driveRight((uint)trackBarSpeed.Value);
        }

        //Halt
        private void buttonStop_Click(object sender, EventArgs e) {
            myMotor.driveStop();
        }
        
        //Event zum Aktualisieren des Anzeigewertes für Geschwindigkeit. Bei Wertänderung des Sliders wird der Text aktualisiert.
        private void trackBarTime_valueChanged(object sender, EventArgs e) {
            labelTimeValue.Text = Convert.ToString(trackBarSpeed.Value) + " mm/min";
        }

        //Text-Box Eingabe
        private void textBoxCommand_KeyDown(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && textBoxIP.Text.Length > 0)
            {
                myMotor.sendCommand(textBoxCommand.Text);
                textBoxCommand.Clear();
            }
        }

        //Buttons für Linksfahrt
        //Schnell
        private void buttonFastLeft_MouseDown(object sender, MouseEventArgs e) {
            myMotor.driveLeft(speedFast);
        }
        //Medium
        private void buttonMediumLeft_MouseDown(object sender, MouseEventArgs e) {
            myMotor.driveLeft(speedMedium);
        }
        //Langsam
        private void buttonSlowLeft_MouseDown(object sender, MouseEventArgs e) {
            myMotor.driveLeft(speedSlow);
        }
        //Buttons für Rechtsfahrt
        //Schnell
        private void buttonFastRight_MouseDown(object sender, MouseEventArgs e) {
            myMotor.driveRight(speedFast);
        }
        //Medium
        private void buttonMediumRight_MouseDown(object sender, MouseEventArgs e) {
            myMotor.driveRight(speedMedium);
        }
        //Langsam
        private void buttonSlowRight_MouseDown(object sender, MouseEventArgs e) {
            myMotor.driveRight(speedSlow);
        }
        //Button für Stopp
        private void button_Release(object sender, MouseEventArgs e) {
            myMotor.driveStop();
        }

        private void toolStripLabel_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://info.hit-karlsruhe.de/info-ws14/Verfahrschiene_Kamera-Koordination/");
        }
    }
}
