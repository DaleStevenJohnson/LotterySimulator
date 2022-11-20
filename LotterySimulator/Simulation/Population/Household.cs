using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperCS;

namespace Simulator.Population
{
    public class Household
    {
        public Household()
        {
            Occupants = new List<Person>();
            var size = GetRandom.Integer(1, 4);
            for (int i = 0; i < size; i++)
            {
                var person = Womb.GiveBirth();
                Occupants.Add(person);
            }
        }
        public List<Person> Occupants { get; set; }

    }
}
