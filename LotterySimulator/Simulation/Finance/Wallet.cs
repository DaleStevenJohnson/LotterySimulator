using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Finance
{
    public class Wallet
    {
        private double Balance;
        public Wallet()
        {
            var r = new Random();
            Balance = r.NextDouble() * r.Next(10, 10000);
        }

        public bool Spend(double cost)
        { 
            if (Balance < cost)
                return false;
            Balance -= cost;
            return true;
        }

        public void Recieve(double amount)
        {
            Balance += amount;
        }
    }
}
