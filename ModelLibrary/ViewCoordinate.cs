using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public struct ViewCoordinate
    {
        public string Name;
        public int Vertical;
        public int Horizontal;

        public ViewCoordinate(string name, int vertical, int horizontal)
        {
            Name = name;
            Vertical = vertical;
            Horizontal = horizontal;
        }
    }
}
