using System;
using System.Windows.Forms;

namespace BlowtorchesAndGunpowder
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            //Application.
            Application.Run(new WireframeLobby());
        }
    }
}
