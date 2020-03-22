using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    class WireframeGameServer
    {
        public static void Main(string[] args)
        {
            // Create a NetworkServer and start listening for incoming connections
            var server = new NetworkServer("http://localhost:4567/");
            Task.Run(() => server.Start());
            Console.WriteLine("Press any key to stop server...");
            Console.ReadKey();
            //Stop the server at the end
            server.Stop();
        }
    }
}
