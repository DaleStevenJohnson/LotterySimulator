using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperCS;

namespace GUI.Model
{
    public class IntDataItem : ObservableObject, IDataItem
    {
        private int _data;
        private string _label;
        public IntDataItem(string label, ref int data)
        {
            _label = label;
            _data = data;
        }

        public string Label { get => _label; }
        public int Data { get => _data; set => RaiseAndSetIfChanged(ref _data, value); }
    }
}
