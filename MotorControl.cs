using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;


namespace Motor_Controll_App
{


    class MotorControl {
        
        //Fields
        private string remoteIp;
        private short remotePort;
        private short lokalerPort = 403; //
        UdpClient localUdpClient;
        
        public MotorControl() {
            
            //Erstellen eines Rechnerseitigen UDP Clienten
            localUdpClient = new UdpClient(lokalerPort);
        }
        public MotorControl(string motorIp, short motorPort)
        {
            //Erstellen eines Rechnerseitigen UDP Clienten
            localUdpClient = new UdpClient(lokalerPort);
            remoteIp = motorIp;
            remotePort = motorPort;
        }

        public void connectMotor(string motorIp, short motorPort) {
            try {
                localUdpClient.Connect(remoteIp, remotePort);
                }  
            catch (Exception e ) {
                          Console.WriteLine(e.ToString());
            }
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
    }

}
