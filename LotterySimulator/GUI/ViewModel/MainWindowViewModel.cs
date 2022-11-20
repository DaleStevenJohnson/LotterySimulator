using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator;

namespace GUI.ViewModel
{
    internal class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            Simulation = new Simulation();
        }

        public Simulation Simulation;
    }
}
