using System;
using System.Collections.Generic;
using System.Text;

namespace BlowtorchesAndGunpowder
{
    public class AvailableGame
    {
        public string Gamename;
        public bool UsePincode;
        public AvailableGame(string aGamename, bool aUsePincode)
        {
            Gamename = aGamename;
            UsePincode = aUsePincode;
        }
        public override string ToString()
        {
            return $"{Gamename}" + (UsePincode?" (Pin)":"");
        }
    }
}
