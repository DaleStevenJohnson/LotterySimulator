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
                Communities.Add(new Community());
            }
        }

        public List<Community> Communities { get; set; }    

    }
}