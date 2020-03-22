using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public class Session
    {
        public readonly string LoginUsername;
        public readonly DateTime ValidTo;
        public readonly string Token;
        public Session(string aLoginUsername, DateTime aValidTo, string aToken)
        {
            LoginUsername = aLoginUsername;
            ValidTo = aValidTo;
            Token = aToken;
        }
    }
}
