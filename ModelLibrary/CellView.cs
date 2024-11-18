using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public struct CellView
    {
        public string Name; // TODO: Properties
        public int Vertical;
        public int Horizontal;

        public CellView(string name, int vertical, int horizontal)
        {
            Name = name;
            Vertical = vertical;
            Horizontal = horizontal;
        }
    }
}
