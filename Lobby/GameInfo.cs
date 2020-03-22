using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public class GameInfo
    {
        public readonly string Gamename;
        public readonly bool UsePincode;
        public readonly string Pincode;
        public GameInfo(string aGamename, bool aUsePincode, string aPincode)
        {
            Gamename = aGamename;
            UsePincode = aUsePincode;
            Pincode = aPincode;
        }
    }
}
