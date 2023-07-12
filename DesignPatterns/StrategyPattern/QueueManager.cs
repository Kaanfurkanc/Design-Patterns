using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class QueueManager
    {
        private IQueue _queue;

        public QueueManager(IQueue queue)
        {
            _queue = queue;
        }

        public void SendToQueue(string value)
        {
            _queue.AddToQueue(value);
        }
    }
}
