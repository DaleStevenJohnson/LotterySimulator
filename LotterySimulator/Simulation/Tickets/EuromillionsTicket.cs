using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Tickets
{
    public class EuromillionsTicket : ITicket
    {
        public EuromillionsTicket()
        {
            Numbers = new int[7];
            var r = new Random();
            
            for (int i = 0; i < 5; i++)
            {
                Numbers[i] = r.Next(1, 51);
            }
            Numbers[5] = r.Next(1, 13);
            Numbers[6] = r.Next(1, 13);
        }

        public EuromillionsTicket(int[] numbers)
        {
            Numbers = numbers;
        }

        public int[] Numbers { get;}
    }
}
