using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Collections.Specialized;
using System.Threading.Tasks;
namespace BlowtorchesAndGunpowder
{
    public class NetworkServer
    {
        public static HttpListener _listener;
        public static string _url;

        public NetworkServer(string url)
        {
            _url = url;
            // Create a Http server 
            _listener = new HttpListener();
            _listener.Prefixes.Add(_url);
        }
        public void Start()
        {
            // start listening for incoming connections
            _listener.Start();
            Console.WriteLine("Listening for connections on {0}", _url);

            // Handle requests
            Task listenTask = HandleIncomingConnections();
            listenTask.GetAwaiter().GetResult();
        }
        public void Stop()
        {
            // Close the listener
            _listener.Close();
        }
        public static async Task HandleIncomingConnections()
        {
            bool runServer = true;
            while (runServer)
            {
                // Will wait here until we hear from a connection
                HttpListenerContext ctx = await _listener.GetContextAsync();
                // Peel out the requests and response objects
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;
                // Print out some info about the request
                Console.WriteLine("url:" + req.Url.ToString());
                Console.WriteLine("method:" + req.HttpMethod);
                Console.WriteLine("host:" + req.UserHostName);
                string bodyRequest = "";
                if (req.HasEntityBody)
                {
                    Stream body = req.InputStream;
                    Encoding encoding = req.ContentEncoding;
                    StreamReader reader = new StreamReader(body, encoding);
                    bodyRequest = reader.ReadToEnd();
                    Console.WriteLine("request:" + bodyRequest);
                    body.Close();
                    reader.Close();
                }
                string bodyResponse = handleRequest(bodyRequest);
                Console.WriteLine("response:" + bodyResponse);
                // Write the response info
                byte[] data = Encoding.UTF8.GetBytes(bodyResponse);
                resp.ContentEncoding = Encoding.UTF8;
                resp.ContentLength64 = data.LongLength;
                // Write out to the response stream (asynchronously), then close it
                await resp.OutputStream.WriteAsync(data, 0, data.Length);
                resp.Close();
            }
        }
        private static string handleRequest(string bodyRequest)
        {
            NameValueCollection requestData = HttpUtility.ParseQueryString(bodyRequest);
            if (requestData["action"] == "create_login")
            {
                return handleCreateLoginRequest(requestData);
            }
            else if (requestData["action"] == "update_login")
            {
                return handleUpdateLoginRequest(requestData);
            }
            else if (requestData["action"] == "create_session")
            {
                return handleCreateSessionRequest(requestData);
            }
            else if (requestData["action"] == "remove_session")
            {
                return handleRemoveSessionRequest(requestData);
            }
            else if (requestData["action"] == "list_loggedinuser")
            {
                return handleListLoggedInUserRequest(requestData);
            }
            else if (requestData["action"] == "create_game")
            {
                return handleCreateGameRequest(requestData);
            }
            else if (requestData["action"] == "list_createdgame")
            {
                return handleListCreatedGameRequest(requestData);
            }
            else if (requestData["action"] == "join_game")
            {
                return handleJoinGameRequest(requestData);
            }
            else if (requestData["action"] == "game_update")
            {
                return handleGameUpdateRequest(requestData);
            }
            else
            {
                return handleNonMatchingRequest(requestData);
            }
        }
        private static string handleCreateLoginRequest(NameValueCollection requestData)
        {
            var responseData = HttpUtility.ParseQueryString("");
            if (LoginAccountList.TryAddLogin(new LoginAccount(requestData["username"], SecurePasswordHasher.Hash(requestData["password"]), requestData["playername"])))
                responseData.Add("result", "success");
            else
                responseData.Add("result", "fail");
            return responseData.ToString();
        }
        private static string handleUpdateLoginRequest(NameValueCollection requestData)
        {
            var responseData = HttpUtility.ParseQueryString("");
            if (LoginAccountList.TryUpdateLogin(requestData["username"], SecurePasswordHasher.Hash(requestData["newpassword"]), requestData["newplayername"], requestData["oldpassword"], requestData["oldplayername"]))
                responseData.Add("result", "success");
            else
                responseData.Add("result", "fail");
            return responseData.ToString();
        }
        private static string handleCreateSessionRequest(NameValueCollection requestData)
        {
            var responseData = HttpUtility.ParseQueryString("");
            var validLoginAccount = LoginAccountList.GetValidLogin(requestData["username"], requestData["password"]);
            if (validLoginAccount != null)
            {
                Session newSession = new Session(requestData["username"], DateTime.Now.AddHours(23), Convert.ToBase64String(Guid.NewGuid().ToByteArray()));
                if (SessionList.TryAddSession(newSession))
                {
                    LoggedInUserList.AddOrUpdateLoggedInUser(new LoggedInUser(newSession.LoginUsername, validLoginAccount.Playername, ""));
                    responseData.Add("result", "success");
                    responseData.Add("token", newSession.Token);
                    responseData.Add("playername", validLoginAccount.Playername);
                }
                else
                    responseData.Add("result", "fail");
            }
            else
                responseData.Add("result", "fail");
            return responseData.ToString();
        }
        private static string handleRemoveSessionRequest(NameValueCollection requestData)
        {
            var responseData = HttpUtility.ParseQueryString("");
            if (SessionList.TryRemoveSession(requestData["token"], requestData["username"]))
            {
                LoggedInUserList.RemoveLoggedInUser(requestData["username"]);
                responseData.Add("result", "success");
            }
            else
                responseData.Add("result", "fail");
            return responseData.ToString();
        }
        private static string handleListLoggedInUserRequest(NameValueCollection requestData)
        {
            return LoggedInUserList.GetListAsJson();
        }
        private static string handleCreateGameRequest(NameValueCollection requestData)
        {
            var responseData = HttpUtility.ParseQueryString("");
            if(SessionList.IsValidSession(requestData["token"]) &&
               CreatedGameList.TryAddCreatedGame(new CreatedGame(requestData["gamename"], (requestData["usepincode"]=="1")?true:false, requestData["pincode"])))
                responseData.Add("result", "success");
            else
                responseData.Add("result", "fail");
            return responseData.ToString();
        }
        private static string handleListCreatedGameRequest(NameValueCollection requestData)
        {
            return CreatedGameList.GetListAsJson();
        }
        private static string handleJoinGameRequest(NameValueCollection requestData)
        {
            var responseData = HttpUtility.ParseQueryString("");
            var session = SessionList.GetValidSession(requestData["token"]);
            var createdGame = CreatedGameList.GetCreatedGame(requestData["gamename"]);
            if (session != null && createdGame != null)
            {
                if(createdGame.TryAddPlayer(session.Token, new Player(LoggedInUserList.GetLoggedInUser(session.LoginUsername).Playername)) && LoggedInUserList.UpdateCurrentGamenameOnLoggedInUser(session.LoginUsername, requestData["gamename"]))
                    responseData.Add("result", "success");
                else
                    responseData.Add("result", "fail");
            }
            else
                responseData.Add("result", "fail");
            return responseData.ToString();
        }
        private static string handleNonMatchingRequest(NameValueCollection requestData)
        {
            var responseData = HttpUtility.ParseQueryString("");
            responseData.Add("result", "fail");
            return responseData.ToString();
        }
        private static string handleGameUpdateRequest(NameValueCollection requestData)
        {
            var responseData = HttpUtility.ParseQueryString("");
            var createdGame = CreatedGameList.GetCreatedGame(requestData["gamename"]);
            if (createdGame != null && createdGame.HasPlayer(requestData["token"]))
            {                
                //requestData["fromtrans"]
            }
            else
                responseData.Add("result", "fail");
            return responseData.ToString();
        }
    }
}
