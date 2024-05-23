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
        UdpClient fUdpServer = new UdpClient();
        IPEndPoint fLocalEndPoint = new IPEndPoint(IPAddress.Loopback, UDP_PORT);
        IPEndPoint fServerEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), UDP_PORT);
        public void Close()
        {
            fUdpServer.Close();
        }
        public void SendMessage(String aMessage)
        {
            byte[] datagram = Encoding.ASCII.GetBytes(aMessage);
            //fUdpServer.ExclusiveAddressUse = false;
            //fUdpServer.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //fUdpServer.Client.Bind(fLocalEndPoint);
            fUdpServer.Send(datagram, datagram.Length, fServerEndPoint);
        }
    }
}
