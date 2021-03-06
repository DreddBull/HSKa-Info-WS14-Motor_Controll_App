﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Net.NetworkInformation;



namespace Lexium_MDrive_Test_GUI
{
    /// <summary>
    ///  Objekt zum Verwalten der UDP Kommunikation. Beinhaltet Parameter für IP und Port des Remote Gerätes.
    /// </summary>
    public class MotorControl {
        
        //Fields
        private string remoteIPString;                      //Motor IP im string Format
        private IPAddress remoteIP;                         //Motor IP im IPAdress Format (bereits verifiziert)
        private int remotePort;                             //Motor Port
        private UdpClient localUdpClient;                   //Objekt zum Handlen der UDP Verbindung
        private IPEndPoint localIPEndPoint;                 //Objekt zum Handlen von eingehenden UDP Nachrichten
        private Ping pinger;                                //Objekt zum Prüfen ob der Motor erreichbar ist
        private PingReply reply;                            //Objekt zum Auswerten der Ping-Rückmeldung
        
        //Motorkonstanten
        private static string configPort2 = "Is=2,2,1";     //Konfigurationsbefehl um Input2 in Anschlag-Rechts zu setzen (MCode Anleitung für mehr Informationen)
        private static string configPort3 = "Is=3,3,1";     //Konfigurationsbefehl um Input3 in Anschlag-Links zu setzen (MCode Anleitung für mehr Informationen)
        private static string configCurrent = "Rc=75";      //Konfigurationsbefehl um den Betriebsstrom auf 75% zu begrenzen
        private static int localPort = 403;                 //lokaler Port für UDP Kommmunikation
        private static float radius1 = (float)10.35;        //Radius des Zahnrades am Motorschaft
        private static float radius2 = (float)40.75;        //Radius des großen Zahnrades mit v = v Zahnrad-Motorschaft 
        private static float radius3 = (float)20.37125;     //Radius des kleinen Zahnrades, welches sich mit dem großen Zahnrad dreht
        private static int stepsPerRev = 51200;             //Schritte Pro Umdrehung



        /// <summary>
        /// Erzeugt ein MotorControl Objekt und initiiert einen UDP Clienten sowie ein IPEndPoint
        /// </summary>
        public MotorControl() {
            //Erstellen eines Rechnerseitigen UDP Clienten
            localUdpClient = new UdpClient(localPort);
            //Erstellen eines Rechnerseitigen IPEndPoints welcher alle Befehle im Netzwerk empfängt.
            localIPEndPoint = new IPEndPoint(IPAddress.Any, 0);
            //Erstellen des Pinger Objektes
            pinger = new Ping();
        }

        /// <summary>
        /// Zerstört das MotorControl Objekt.
        /// </summary>
        ~MotorControl() {
            //Erstellen eines Rechnerseitigen UDP Clienten
            localUdpClient.Close();
        }

        //Private Methoden
        /// <summary>
        ///Prüft den string "remoteIPString" im MotorControl Objekt ob dies eine valide IP Adresse ist, setzt diese anschließend als IPAddress Objekt "remoteIP". Falls die IP ungültig ist, gibt die Funktion ein "false" wieder.
        /// <summary>
        private bool parseIP() {
            if(IPAddress.TryParse(remoteIPString, out remoteIP) == false) {
                return false;
            } 
            else { 
                return true; 
            }
        }

        /// <summary>
        ///  Berechnet aus der Geschwindigkeit in mm/min die Schritte/sek mittels der in der Konfiguration angegebenen Übersetzung
        /// </summary>
        /// <param name="velocitySled">Hier wird die Geschwindigkeit in mm/min für den Kameraschlitten angegeben.</param>
        private uint calcStepSpeed(uint velocitySled) {
            float stepSpeed = (((float)velocitySled / (float)60) * radius2 * (float)stepsPerRev) / (2 * (float)Math.PI * radius1 * radius3);
            return (uint)stepSpeed; //Ausgabe Schritte/sekunde als Ganzzahl
        }

        /// <summary>
        /// Sendet die Initialen Konfigurationswerte
        /// </summary>
        private void sendConfig() {
            sendCommand(configPort2);
            System.Threading.Thread.Sleep(10); //Eine unterbrechung zwischen den Befehlen hat eine stabilere Übertragung herbeigeführt
            sendCommand(configPort3);
            System.Threading.Thread.Sleep(10);
            sendCommand(configCurrent);
        }

        //Öffentliche Methoden
        /// <summary>
        /// Sendet den übergebenen String an den verbundenen Motor.
        /// </summary>
        /// <param name="command">MCode Befehl welcher an den Lexium MDrive Motor übertragen werden soll. z.B.:SL 50000 (vor Übermittlung wird en CR "\r" angehängt.</param>
        public void sendCommand(string command) {
            try {
                // Convert command to Bytes
                Byte[] sendBytes = Encoding.ASCII.GetBytes(command + "\r");
                localUdpClient.Send(sendBytes, sendBytes.Length);
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        ///  Sendet das Ende Zeichen bzw. Carry-Return "\r"
        /// </summary>
        public void sendEndSign()
        {
            try
            {
                Byte[] endByte = Encoding.ASCII.GetBytes("\r");
                localUdpClient.Send(endByte, endByte.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// Stellt eine UDP Verbindung zum Motor her.
        /// </summary>
        /// <param name="motorIP">Hier wird die IP Adresse des Lexium MDrive Motors als string eingegeben.</param>
        /// <param name="motorPort">Hier wird der Port des Lexium MDrive Motors als int eigegeben. (MCode UDP/TCP: 503)</param>
        public bool connect(string motorIP, int motorPort) {
            try {
                remoteIPString = motorIP;
                remotePort = motorPort;
                if (parseIP() == false) {                           //Prüfen ob IP korrekt ist
                    MessageBox.Show("Fehlerhafte IP Adresse.");
                    return false; 
                }
                if (checkConnection() == true) {                    //Prüfen ob Motor erreichbar ist
                    localUdpClient.Connect(remoteIP, remotePort);   //Baut "Verbindung" auf
                    sendConfig();                                   //Übertragen der Konfiguration
                    return true;
                } else { 
                    return false; 
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        /// <summary>
        /// Prüft ob Motor noch erreichbar ist.
        /// </summary>
        public bool checkConnection() {
            try {
                reply = pinger.Send(remoteIP);                   //Senden einer Anfrage und speichern der Antwort
                if (reply.Status == IPStatus.Success){          //Prüfen ob Motor antwortet bzw. erreichbar ist  
                    return true;
                } else {
                    MessageBox.Show("Motor nicht erreichbar.\nFehler: " + reply.Status.ToString());
                    return false; 
                }
            }
            catch (PingException e) {
                MessageBox.Show("Ping Fehler:" + e.ToString());
                return false;
            }
        }


        /// <summary>
        /// Lässt den motor mit der eingegebenen Geschwindigkeit nach Links drehen.
        /// </summary>
        /// <param name="velocity">Hier wird die gewünschte Verfahrgeschwindigkeit in mm/min eingegeben.</param>
        public void driveLeft(uint velocity)
        {
            sendCommand("SL " + Convert.ToString(calcStepSpeed(velocity))); //Sends Command
        }

        /// <summary>
        /// Lässt den motor mit der eingegebenen Geschwindigkeit nach Rechts drehen.
        /// </summary>
        /// <param name="velocity">Hier wird die gewünschte Verfahrgeschwindigkeit in mm/min eingegeben.</param>
        public void driveRight(uint velocity) {
            sendCommand("SL -" + Convert.ToString(calcStepSpeed(velocity)));
        }

        /// <summary>
        /// Stoppt die Motorbewegung
        /// </summary>
        public void driveStop()
        {
            sendCommand("SL 0");
        }   
         
        //get/set Methoden
        /// <summary>
        ///  Setzen der IP des MotorControl Objektes.
        /// </summary>
        public string RemoteIPString {
            get {
                return remoteIPString;
            }
            set {
                remoteIPString = value;
                parseIP();
            }
        }

        /// <summary>
        ///  Setzen des Ports des MotorControl Objektes.
        /// </summary>
        public int RemotePort {
            get {
                return remotePort;
            }
            set {
                remotePort = value;
            }
        }
    }

}
