using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;


namespace Motor_Controll_App
{


    class MotorControl {
        
        //Fields
        private string remoteIPString;      //Motor IP im string Format
        private IPAddress remoteIP;         //Motor IP im IPAdress Format (bereits verifiziert)
        private int remotePort;             //Motor Port
        static int lokalerPort = 403;       //lokaler Port für UDP Kommmunikation
        private UdpClient localUdpClient;   //Objekt zum Handlen der UDP Verbindung
        private IPEndPoint lovalIpEndPoint; //Objekt zum Handlen von eingehenden UDP Nachrichten
         
        //get/set Methoden
        public string RemoteIPstring {
            get {
                return remoteIPString;
            }
            set {
                remoteIPString = value;
            }
        }
        public int RemotePort {
            get {
                return remotePort;
            }
            set {
                remotePort = value;
            }
        }
        
        //allgemeiner Konstruktor
        public MotorControl() {
            //Erstellen eines Rechnerseitigen UDP Clienten
            localUdpClient = new UdpClient(lokalerPort);
            lovalIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
        }
        ~MotorControl()
        {
            //Erstellen eines Rechnerseitigen UDP Clienten
            localUdpClient.Close();
        }

        //Konstruktor mit vorgegebener Adresse und Port
        /*
        public MotorControl(string motorIP, int motorPort)
        {
            //Erstellen eines Rechnerseitigen UDP Clienten
            localUdpClient = new UdpClient(lokalerPort);
            remoteIPString = motorIP;
            remotePort = motorPort;
            if(IPAddress.TryParse(remoteIPString, out remoteIP)) { 
            } else { MessageBox.Show("Fehlerhafte IP Adresse"); }
        }
         */

        //Prüft den string "remoteIPString" ob dies eine valide IP Adresse ist, setzt diese anschließend als IPAddress Objekt "remoteIP"
        public bool parseIP() {
            if(IPAddress.TryParse(remoteIPString, out remoteIP) == false) {
                MessageBox.Show("Fehlerhafte IP Adresse");
                return false;
            } 
            else { 
                return true; 
            }
        }

        //Sendet einen Befehl an den Motor
        public void sendCommand(string command) {
            try
            {
                // Convert command to Bytes
                Byte[] sendBytes = Encoding.ASCII.GetBytes(command);

                localUdpClient.Send(sendBytes, sendBytes.Length);

                /*
                // Sends a message to a different host using optional hostname and port parameters.
                UdpClient udpClientB = new UdpClient();
                udpClientB.Send(sendBytes, sendBytes.Length, "AlternateHostMachineName", 11000);

                //IPEndPoint object will allow us to read datagrams sent from any source.
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                // Blocks until a message returns on this socket from a remote host.
                Byte[] receiveBytes = localUdpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);

                // Uses the IPEndPoint object to determine which of these two hosts responded.
                Console.WriteLine("This is the message you received " +
                                            returnData.ToString());
                Console.WriteLine("This message was sent from " +
                                            RemoteIpEndPoint.Address.ToString() +
                                            " on their port number " +
                                            RemoteIpEndPoint.Port.ToString());

                localUdpClient.Close();
                udpClientB.Close();
                */

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //Verbindung zu Motor Aufbauen
        public void connect(string motorIP, int motorPort) {
            try
            {
                remoteIPString = motorIP;
                remotePort = motorPort;
                if (parseIP() == false) {
                    MessageBox.Show("Fehlerhafte IP Adresse");
                    return; 
                } 
                localUdpClient.Connect(remoteIP, remotePort);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void disconnect() {
            try
            {
                localUdpClient.Client.Disconnect(false);
                //localUdpClient.Client.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }

}
