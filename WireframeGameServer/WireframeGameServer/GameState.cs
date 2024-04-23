using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public class GameState
    {
        private readonly ConcurrentDictionary<string, string> _keyValueList = new ConcurrentDictionary<string, string>();
        private readonly ConcurrentDictionary<TimeSpan, string> _transactionList = new ConcurrentDictionary<TimeSpan, string>();
        public bool TryUpdateState(string aKey, string aNewValue, TimeSpan aGameClock)
        {
            var oldValue = _keyValueList[aKey];
            if (oldValue != aNewValue)
            {
                if (_keyValueList.TryUpdate(aKey, aNewValue, oldValue))
                {
                    //AddTransaction(aGameClock, aKey, aNewValue);
                }
                else
                    return false;
            }
            return true;
        }
    }
}
