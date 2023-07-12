using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concretes
{
    public class MsMQ : IQueue
    {
        public void AddToQueue(string value)
        {
            Console.WriteLine($"value : {value}  adding to MsMQ ..");
        }
    }
}
