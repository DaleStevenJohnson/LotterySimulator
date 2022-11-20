using Simulator.Population;

namespace Simulator
{
    public class Simulation
    {
        public Simulation(int size)
        {
            
            Communities = new List<Community>();
            for (int i = 0; i < size; i++)
            {
                AddCommunity();
            }
        }

        public List<Community> Communities { get; set; }

        public void AddCommunity()
        {
            Communities.Add(new Community());
        }

        public int SumHouseholds()
        {
            var total = 0;
            foreach (var c in Communities)
            {
                total += c.GetHouseholdCount();
            }
            return total;
        }

        public int SumOccupants()
        {
            var total = 0;
            foreach (var c in Communities)
            {
                total += c.GetOccupantCount();
            }
            return total;
        }
      
    }
}