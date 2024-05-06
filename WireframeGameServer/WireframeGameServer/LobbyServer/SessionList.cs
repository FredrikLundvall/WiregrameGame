using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public class SessionList
    {
        private static readonly ConcurrentDictionary<string, Session> _sessionList = new ConcurrentDictionary<string, Session>();
        public static bool TryAddSession(Session aSession)
        {
            return _sessionList.TryAdd(aSession.Token, aSession);
        }
        public static bool TryRemoveSession(string aToken, string aUsername)
        {
            if (!_sessionList.ContainsKey(aToken))
                return true;
            var session = _sessionList[aToken];
            if (session.LoginUsername != aUsername)
                return false;
            Session oldSession;
            return _sessionList.TryRemove(aToken, out oldSession);
        }
        public static bool TryUpdateSession(string Token, DateTime newValidTo, DateTime oldValidTo)
        {
            var oldSession = _sessionList[Token];
            Session updateableSession = new Session(oldSession.LoginUsername, newValidTo, Token);
            //TryUpdate gör inte djup jämförelse (går troligtvis att lägga till stöd för compare i Session)
            if (oldSession.ValidTo == oldValidTo)
                return _sessionList.TryUpdate(Token, updateableSession, oldSession);
            else
                return false;
        }
        public static Session GetValidSession(string aToken)
        {
            Session session;
            _sessionList.TryGetValue(aToken, out session);
            return (session != null && session.ValidTo >= DateTime.Now) ? session : null;
        }
        public static bool ValidateAndUpdateSession(string aToken)
        {
            Session oldSession = GetValidSession(aToken);
            if (oldSession == null)
                return false;
            return _sessionList.TryUpdate(aToken, new Session(oldSession.LoginUsername, DateTime.Now.AddHours(23), aToken), oldSession);
        }
        public static bool IsValidSession(string aToken)
        {
            return (GetValidSession(aToken) != null);
        }
    }
}
