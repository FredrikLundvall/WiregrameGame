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
        public TimeSpan GameClock;
        [Newtonsoft.Json.JsonIgnore]
        public readonly string Pincode;
        private ConcurrentDictionary<string, Player> _playerList = new ConcurrentDictionary<string, Player>();
        public CreatedGame(string aGamename, bool aUsePincode, string aPincode)
        {
            Gamename = aGamename;
            UsePincode = aUsePincode;
            Pincode = aPincode;
        }
        public bool TryAddPlayer(String aToken, Player aPlayer)
        {
            return _playerList.TryAdd(aToken, aPlayer);
        }
        public Player GetPlayer(string aToken)
        {
            Player player;
            _playerList.TryGetValue(aToken, out player);
            return player;
        }
        public bool HasPlayer(string aToken)
        {
            return _playerList.ContainsKey(aToken);
        }
        public bool TryRemovePlayer(string aToken)
        {
            Player oldPlayer;
            return _playerList.TryRemove(aToken, out oldPlayer);
        }
    }
}
