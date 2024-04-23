using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace BlowtorchesAndGunpowder
{
    public class LobbyClient
    {
        public bool ConnectionFailing { get; private set; } = false;

        private static readonly HttpClient _client = new HttpClient();
        private readonly Settings _settings;
        public LobbyClient(Settings settings)
        {
            _settings = settings;
        }
        public bool CreateLogin(LoginAccount loginAccount)
        {
            var values = new Dictionary<string, string>
            {
               { "action", "create_login" },
               { "username", loginAccount.Username },
               { "password", loginAccount.Password },
               { "playername", loginAccount.Playername }
            };
            return PostReturningBool(new FormUrlEncodedContent(values));
        }

        public bool UpdateLogin(LoginAccount loginAccount,string oldPassword,string oldPlayername)
        {
            var values = new Dictionary<string, string>
            {
               { "action", "update_login" },
               { "username", loginAccount.Username },
               { "newpassword", loginAccount.Password },
               { "newplayername", loginAccount.Playername },
               { "oldpassword", oldPassword },
               { "oldplayername", oldPlayername }
            };
            return PostReturningBool(new FormUrlEncodedContent(values));
        }

        public LoginSession CreateSession(string username, string password)
        {
            var values = new Dictionary<string, string>
            {
               { "action", "create_session" },
               { "username", username },
               { "password", password },
            };
            string responseString = PostReturningString(new FormUrlEncodedContent(values));
            NameValueCollection responseData = HttpUtility.ParseQueryString(responseString);
            if (responseData["result"] == "success" && responseData["token"] != "")
            {
                return new LoginSession(username, password, responseData["playername"], responseData["token"]);
            }
            else
                return null;
        }
        public bool RemoveSession(LoginSession loginSession)
        {
            var values = new Dictionary<string, string>
            {
               { "action", "remove_session" },
               { "username", loginSession.Username},
               { "token", loginSession.SessionToken },
            };
            return PostReturningBool(new FormUrlEncodedContent(values));
        }
        public bool CreateGame(string aToken, GameInfo aGameInfo)
        {
            var values = new Dictionary<string, string>
            {
               { "action", "create_game" },
               { "token", aToken },
               { "gamename", aGameInfo.Gamename },
               { "usepincode", (aGameInfo.UsePincode)?"1":"0" },
               { "pincode", aGameInfo.Pincode }
            };
            return PostReturningBool(new FormUrlEncodedContent(values));
        }
        public bool JoinGame(string aGamename, string aPincode, string aToken)
        {
            var values = new Dictionary<string, string>
            {
               { "action", "join_game" },
               { "token", aToken },
               { "gamename", aGamename },
               { "pincode", aPincode }
            };
            return PostReturningBool(new FormUrlEncodedContent(values));
        }
        public List<LoggedInUser> GetListLoggedInUser()
        {
            var values = new Dictionary<string, string>
            {
               { "action", "list_loggedinuser" }
            };
            string responseString = PostReturningString(new FormUrlEncodedContent(values));
            try
            {
                if (responseString != "")
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<List<LoggedInUser>>(responseString);
                else
                    return new List<LoggedInUser>();
            }
            catch
            {
                return new List<LoggedInUser>();
            }
        }
        public async Task<List<LoggedInUser>> GetListLoggedInUserAsync()
        {
            var values = new Dictionary<string, string>
            {
               { "action", "list_loggedinuser" }
            };
            string responseString = await PostReturningStringAsync(new FormUrlEncodedContent(values));
            try
            {
                if (responseString != "")
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<List<LoggedInUser>>(responseString);
                else
                    return new List<LoggedInUser>();
            }
            catch
            {
                return new List<LoggedInUser>();
            }
        }
        public async Task<List<AvailableGame>> GetListAvailableGameAsync()
        {
            var values = new Dictionary<string, string>
            {
               { "action", "list_createdgame" }
            };
            string responseString = await PostReturningStringAsync(new FormUrlEncodedContent(values));
            try
            {
                if (responseString != "")
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<List<AvailableGame>>(responseString);
                else
                    return new List<AvailableGame>();
            }
            catch
            {
                return new List<AvailableGame>();
            }
        }
        private bool PostReturningBool(FormUrlEncodedContent content)
        {
            string responseString = PostReturningString(content);
            NameValueCollection responseData = HttpUtility.ParseQueryString(responseString);
            if (responseData["result"] == "success")
                return true;
            else
                return false;
        }
        private string PostReturningString(FormUrlEncodedContent content)
        {
            try
            {
                var response = _client.PostAsync("http://" + _settings.ServerIp + ':' + _settings.ServerPort.ToString(), content);
                response.Wait();
                var responseString = response.Result.Content.ReadAsStringAsync();
                responseString.Wait();
                string responseAsString = responseString.Result;
                ConnectionFailing = false;
                return responseAsString;
            }
            catch
            {
                ConnectionFailing = true;
                return "";
            }
        }
        private async Task<string> PostReturningStringAsync(FormUrlEncodedContent content)
        {
            try
            {
                var response = await _client.PostAsync("http://" + _settings.ServerIp + ':' + _settings.ServerPort.ToString(), content);
                var responseString = await response.Content.ReadAsStringAsync();
                ConnectionFailing = false;
                return responseString;
            }
            catch
            {
                ConnectionFailing = true;
                return "";
            }
        }
    }
}
