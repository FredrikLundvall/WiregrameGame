using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public class LoginInfo
    {
        public readonly string Username;
        public readonly string Password;
        public readonly bool AutomaticLogin;
        public LoginInfo(string aUsername, string aPassword, bool aAutomaticLogin)
        {
            Username = aUsername;
            Password = aPassword;
            AutomaticLogin = aAutomaticLogin;
        }
    }
}
