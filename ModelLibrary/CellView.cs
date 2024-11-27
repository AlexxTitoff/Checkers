using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public struct CellView
    {
        public string Name { get; private set; } 
        public int Vertical { get; private set; }
        public int Horizontal { get; private set; }

        public CellView(string name, int vertical, int horizontal)
        {
            Name = name;
            Vertical = vertical;
            Horizontal = horizontal;
        }
    }
}
