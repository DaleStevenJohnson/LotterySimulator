using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GUI.Model;
using HelperCS;
using Simulator;

namespace GUI.ViewModel
{
    internal class MainWindowViewModel : ObservableObject
    {
        private int _communityCount = 4;

        public ICommand AddCommunityButtonCommand { get; } 
        public MainWindowViewModel()
        {
            AddCommunityButtonCommand = new SimpleCommand(_ => AddCommunity());
            Simulation = new Simulation(_communityCount);
            CommunityCountDataItem = new IntDataItem("Communities", ref _communityCount);
        }

        public Simulation Simulation;
        
        public IDataItem CommunityCountDataItem { get; set; }
        //private int CommunityCount { get => _communityCount; set => RaiseAndSetIfChanged(ref _communityCount, value); }

        private void Update()
        {
            CommunityCountDataItem.Data = Simulation.Communities.Count;
        }

        private void AddCommunity()
        {
            Simulation.AddCommunity();
            Update();

        }
    }
}
