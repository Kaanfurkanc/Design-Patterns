using StrategyPattern.Strategy;

namespace StrategyPattern.Concretes
{
    public class MsMQ : IQueueManager
    {
        public void AddToQueue(string value)
        {
            Console.WriteLine($"value : {value}  adding to MsMQ ..");
        }
    }
}
