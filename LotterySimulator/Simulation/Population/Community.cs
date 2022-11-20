using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Population
{
    public class Community
    {
        private List<Household> Households;
        private TicketShop TicketShop;
        public Community()
        {
            Households = new List<Household>();
            TicketShop = new TicketShop();
            var r = new Random();
            var houses = r.Next(20, 1000);
            for (int i = 0; i < houses; i++)
            {
                Households.Add(new Household());
            }
        }

        public int GetHouseholdCount()
        {
            return Households.Count;
        }

        public int GetOccupantCount()
        {
            var total = 0; 
            foreach (var house in Households)
            {
                total += house.GetOccupantCount();
            }
            return total;
        }
    }
}
