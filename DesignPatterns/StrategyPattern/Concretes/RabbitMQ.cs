using StrategyPattern.Strategy;

namespace StrategyPattern.Concretes
{
    public class RabbitMQ : IQueueManager
    {
        public void AddToQueue(string value)
        {
            Console.WriteLine($"value : {value}  adding to RabbitMQ ..");
        }
    }
}
