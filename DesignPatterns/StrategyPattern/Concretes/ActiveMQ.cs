using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concretes
{
    public class ActiveMQ : IQueue
    {
        public void AddToQueue(string value)
        {
            Console.WriteLine($"value : {value}  adding to ActiveMQ ..");
        }
    }
}
