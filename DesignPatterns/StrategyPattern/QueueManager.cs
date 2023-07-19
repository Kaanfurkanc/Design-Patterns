using StrategyPattern.Strategy;

namespace StrategyPattern
{
    public class QueueManager
    {
        private IQueueManager _queue;

        public QueueManager(IQueueManager queue)
        {
            _queue = queue;
        }

        public QueueManager()
        {
            
        }

        public void SendToQueue(string value)
        {
            _queue.AddToQueue(value);
        }

        public void SetStrategy(IQueueManager queue)
        {
            _queue = queue;
        }
    }
}
