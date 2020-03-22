using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public class CreatedGameList
    {
        private static readonly ConcurrentDictionary<string, CreatedGame> _createdGameList = new ConcurrentDictionary<string, CreatedGame>();
        public static bool TryAddCreatedGame(CreatedGame aCreatedGame)
        {
            return _createdGameList.TryAdd(aCreatedGame.Gamename, aCreatedGame);
        }
        public static CreatedGame GetCreatedGame(string aCreatedGame)
        {
            CreatedGame createdGame;
            _createdGameList.TryGetValue(aCreatedGame, out createdGame);
            return createdGame;
        }
        public static bool TryRemoveCreatedGame(string aCreatedGame)
        {
            CreatedGame oldCreatedGame;
            return _createdGameList.TryRemove(aCreatedGame, out oldCreatedGame);
        }
        public static string GetListAsJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(_createdGameList.Values);
        }
    }
}
