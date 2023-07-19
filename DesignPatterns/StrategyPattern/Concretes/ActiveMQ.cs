using StrategyPattern.Strategy;

namespace StrategyPattern.Concretes
{
    public class ActiveMQ : IQueueManager
    {
        public void AddToQueue(string value)
        {
            Console.WriteLine($"value : {value}  adding to ActiveMQ ..");
        }
    }
}
