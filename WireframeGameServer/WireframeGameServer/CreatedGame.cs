using System;
using System.Collections.Concurrent;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public class CreatedGame
    {
        public readonly string Gamename;
        public readonly bool UsePincode;
        [Newtonsoft.Json.JsonIgnore]
        public readonly string Pincode;
        public CreatedGame(string aGamename, bool aUsePincode, string aPincode)
        {
            Gamename = aGamename;
            UsePincode = aUsePincode;
            Pincode = aPincode;
        }
    }
}
