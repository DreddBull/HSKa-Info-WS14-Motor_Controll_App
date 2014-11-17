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
        private string remoteIPString;
        private IPAddress remoteIP;
        private int remotePort;
        static int lokalerPort = 403; //default Port
        private bool isConnected = false; //Verbindungsstatus
        private UdpClient localUdpClient;
        
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
        public bool IsConnected {
            get
            {
                return isConnected;
            }
        }
        
        //allgemeiner Konstruktor
        public MotorControl() {
            //Erstellen eines Rechnerseitigen UDP Clienten
            localUdpClient = new UdpClient(lokalerPort);
        }
        //Konstruktor mit vorgegebener Adresse und Port
        public MotorControl(string motorIP, int motorPort)
        {
            //Erstellen eines Rechnerseitigen UDP Clienten
            localUdpClient = new UdpClient(lokalerPort);
            remoteIPString = motorIP;
            remotePort = motorPort;
            if(IPAddress.TryParse(remoteIPString, out remoteIP)) { 
            } else { MessageBox.Show("Fehlerhafte IP Adresse"); }
        }


        public bool parseIP() {
            if(IPAddress.TryParse(remoteIPString, out remoteIP) == false) {
                MessageBox.Show("Fehlerhafte IP Adresse");
                return false;
            } else { return true; }
        }


        public void sendCommand(string command) {
            try
            {
                // Convert command to Bytes
                Byte[] sendBytes = Encoding.ASCII.GetBytes(command);

                localUdpClient.Send(sendBytes, sendBytes.Length);

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

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //Verbindung zu Motor Aufbauen
        public void connect() {
            try
            {
                if (parseIP() == false) { return; } 
                //Prüfen ob bereits eine Verbindung besteht, wenn ja wird diese getrennt und eine neue Verbindung aufgebaut.
                if(localUdpClient.Client.Connected){
                    localUdpClient.Client.Disconnect(true);
                }
                localUdpClient.Connect(remoteIP, remotePort);
                if (localUdpClient.Client.Connected == true) {
                    isConnected = true;
                }
                
            }
            catch (Exception e)
            {
                isConnected = false;
                MessageBox.Show(e.ToString());
            }
        }
        public void disconnect() {
            try
            {
                localUdpClient.Client.Close();
                isConnected = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }

}
