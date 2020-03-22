using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public class LoginAccountList
    {
        private static readonly ConcurrentDictionary<string, LoginAccount> _loginAccountList = new ConcurrentDictionary<string, LoginAccount>();
        public static bool TryAddLogin(LoginAccount loginAccount)
        {
            return _loginAccountList.TryAdd(loginAccount.Username, loginAccount);
        }
        public static bool TryUpdateLogin(string Username, string newPassword, string newPlayername, string oldPassword, string oldPlayername)
        {
            LoginAccount updateableLoginAccount = new LoginAccount(Username, newPassword, newPlayername);
            //TryUpdate gör inte djup jämförelse (går troligtvis att lägga till stöd för compare i LoginAccount)
            LoginAccount oldLoginAccount;
            if (_loginAccountList.TryGetValue(Username, out oldLoginAccount) && SecurePasswordHasher.Verify(oldPassword, oldLoginAccount.Password) && oldLoginAccount.Playername == oldPlayername)
                return _loginAccountList.TryUpdate(Username, updateableLoginAccount, oldLoginAccount);
            else
                return false;
        }
        public static LoginAccount GetValidLogin(string username, string password)
        {
            LoginAccount loginAccount;
            if(_loginAccountList.TryGetValue(username, out loginAccount) && SecurePasswordHasher.Verify(password, loginAccount.Password))
            {
                return loginAccount;
            }
            return null;
        }
    }
}
