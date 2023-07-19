using StrategyPattern.Strategy;

namespace StrategyPattern.Concretes
{
    public class Kafka : IQueueManager
    {
        public void AddToQueue(string value)
        {
            Console.WriteLine($"value : {value}  adding to Kafka ..");
        }
    }
}
