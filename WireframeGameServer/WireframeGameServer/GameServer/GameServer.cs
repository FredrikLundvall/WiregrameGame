using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    internal class GameServer
    {
        const int UDP_PORT = 11000;
        //byte[] myBuffer = new byte[65536];
        private bool fStarted = false;
        private IPEndPoint fLocalEndPoint = new IPEndPoint(IPAddress.Loopback, UDP_PORT);
        private List<IPEndPoint> fAllClientEndpoints = new List<IPEndPoint>();

        public void Start()
        {
             fStarted = true;
             using (var udpClient = new UdpClient())
             {
                var remoteEndPoint = new IPEndPoint(IPAddress.Any, UDP_PORT);
                udpClient.ExclusiveAddressUse = false;
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(fLocalEndPoint);
                Console.WriteLine("Listening for udp on port {0}", UDP_PORT);
                string loggingEvent = "";
                while (fStarted)
                {
                    //IPEndPoint object will allow us to read datagrams sent from any source.
                    var receivedResults = udpClient.Receive(ref remoteEndPoint);
                    if(!fAllClientEndpoints.Any(s => s.ToString() == remoteEndPoint.ToString())) 
                    {
                        fAllClientEndpoints.Add(new IPEndPoint(remoteEndPoint.Address, remoteEndPoint.Port));
                        Console.WriteLine("Adding new client {0}", remoteEndPoint.ToString());
                    }
                    var datagram = Encoding.ASCII.GetString(receivedResults);
                    Console.WriteLine("Receiving udp from {0} - {1}", remoteEndPoint.ToString(), datagram);
                    loggingEvent += datagram;
                    if (datagram.EndsWith("\"FromServer\":false}"))
                    {
                        var clientAction = ClientAction.CreateFromJson(datagram);
                        if (clientAction.PlayerShooting)
                        {
                            SendMessage("You missed!");
                        }
                    }
                }
            }
        }
        public void Stop()
        {
            fStarted = false;
        }
        public void SendMessage(String aMessage)
        {
            UdpClient udpSender = new UdpClient();
            udpSender.ExclusiveAddressUse = false;
            udpSender.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udpSender.Client.Bind(fLocalEndPoint);
            byte[] datagram = Encoding.ASCII.GetBytes(aMessage);
            foreach(var endpoint in fAllClientEndpoints)
            {
                udpSender.Send(datagram, datagram.Length, endpoint);
            }
        }

    }
}
