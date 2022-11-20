using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperCS;

namespace Simulator.Population
{
    public static class Womb
    {
        public static Person GiveBirth()
        {

            var p = new Person(GetRandom.EnumValue<LotteryPersonalities>());
            return p;

        }
    }
}
