using System;
using System.Collections.Concurrent;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public class LoggedInUserList
    {
        private static readonly ConcurrentDictionary<string, LoggedInUser> _loggedInUserList = new ConcurrentDictionary<string, LoggedInUser>();
        public static void AddOrUpdateLoggedInUser(LoggedInUser aLoggedInUser)
        {
            _loggedInUserList.AddOrUpdate(aLoggedInUser.Username, aLoggedInUser, (k, v) => v);
        }
        public static bool UpdateCurrentGamenameOnLoggedInUser(string aUsername, string aCurrentGameName)
        {
            LoggedInUser oldLoggedInUser;
            _loggedInUserList.TryGetValue(aUsername, out oldLoggedInUser);
            if (oldLoggedInUser == null)
                return false;
            LoggedInUser updateableLoggedInUser = new LoggedInUser(aUsername, oldLoggedInUser.Playername, aCurrentGameName);
            return _loggedInUserList.TryUpdate(aUsername, updateableLoggedInUser, oldLoggedInUser);
        }
        public static bool RemoveLoggedInUser(string aUsername)
        {
            LoggedInUser oldLoggedInUser;
            return _loggedInUserList.TryRemove(aUsername, out oldLoggedInUser);
        }
        public static string GetListAsJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(_loggedInUserList.Values);
        }
    }
}
