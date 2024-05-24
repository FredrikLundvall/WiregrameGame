using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    internal class GameClient
    {
        const int UDP_PORT = 11000;
        UdpClient fUdpSender = new UdpClient();
        UdpClient fUdReceiver = new UdpClient();
        private IPEndPoint fLocalEndPoint = new IPEndPoint(IPAddress.Loopback, UDP_PORT);
        IPEndPoint fServerEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), UDP_PORT);
        public GameClient()
        {
            fUdpSender.ExclusiveAddressUse = false;
            fUdpSender.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            fUdpSender.Client.Bind(fLocalEndPoint);
            fUdReceiver.ExclusiveAddressUse = false;
            fUdReceiver.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            fUdReceiver.Client.Bind(fLocalEndPoint);
        }
        public void Close()
        {
            Stop();
            fUdpSender.Close();
        }
        public void SendMessage(String aMessage)
        {
            byte[] datagram = Encoding.ASCII.GetBytes(aMessage);
            fUdpSender.Send(datagram, datagram.Length, fServerEndPoint);
        }

        private bool fStarted = false;
        public void Start()
        {
            fStarted = true;
            Console.WriteLine("Listening for udp from server on port {0}", fServerEndPoint.Port);
            string loggingEvent = "";
            while (fStarted)
            {
                //IPEndPoint object will allow us to read datagrams sent from any source.
                var receivedResults = fUdReceiver.Receive(ref fServerEndPoint);
                var datagram = Encoding.ASCII.GetString(receivedResults);
                Console.WriteLine("Receiving udp from server {0} - {1}", fServerEndPoint.ToString(), datagram);
                loggingEvent += datagram;
            }
            fUdReceiver.Close();
        }
        public void Stop()
        {
            fStarted = false;
        }
    }
}
