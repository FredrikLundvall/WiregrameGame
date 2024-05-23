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
        public IPEndPoint fLocalEndPoint = new IPEndPoint(IPAddress.Loopback, UDP_PORT);

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
                    var datagram = Encoding.ASCII.GetString(receivedResults);
                    Console.WriteLine("Receiving udp from {0} - {1}", remoteEndPoint.ToString(), datagram);
                    loggingEvent += datagram;
                }
            }
        }
        public void Stop()
        {
            fStarted = false;
        }
    }
}
