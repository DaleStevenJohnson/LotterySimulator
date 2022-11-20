using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Population
{
    public class Person
    {
        public Person(LotteryPersonalities lotteryPersonality)
        {
            LotteryPersonality = lotteryPersonality;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public LotteryPersonalities LotteryPersonality;
    }
}
