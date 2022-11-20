using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Model
{
    internal interface IDataItem
    {
        public string Label { get; }
        public int Data { get; set; }
    }
}
