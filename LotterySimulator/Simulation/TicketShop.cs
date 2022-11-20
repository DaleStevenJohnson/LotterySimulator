using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator.Finance;
using Simulator.Tickets;

namespace Simulator
{
    internal class TicketShop
    {
        private double SalesTotal = 0;
        public TicketShop()
        {

        }


        private Dictionary<string, int> Menu = new Dictionary<string, int>()
        {
            { "Euromillions", 1 },
        };

        public ITicket? PurchaseTicket(string ticketType, Wallet wallet)
        {
            if (!ValidatePurchaseConditions(ticketType, wallet))
                return null;

            var ticketCost = Menu[ticketType];
            SalesTotal += ticketCost;

            switch (ticketType)
            {
                case "Euromillions":
                    return new EuromillionsTicket();
                default:
                    return new EuromillionsTicket();
            }
        }

        private bool ValidatePurchaseConditions(string ticketType, Wallet wallet)
        {
            if (Menu.ContainsKey(ticketType))
            {
                return wallet.Spend(Menu[ticketType]);
            }
            return false;
        }
    }
}
