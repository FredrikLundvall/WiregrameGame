using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public class LoginSession
    {
        public readonly string Username;
        public readonly string Password;
        public readonly string Playername;
        public readonly string SessionToken;
        public LoginSession(string aUsername, string aPassword, string aPlayername, string aSessionToken)
        {
            Username = aUsername;
            Password = aPassword;
            Playername = aPlayername;
            SessionToken = aSessionToken;
        }
    }
}
