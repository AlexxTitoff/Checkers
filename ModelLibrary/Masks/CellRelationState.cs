using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Masks
{
    public static class CellRelationState
    {
        public static Dictionary<string, uint> boardCellMask = new Dictionary<string, uint>()
        {
            { "a1", (uint)1 << 0 },
            { "c1", (uint)1 << 1},
            { "e1", (uint)1 << 2},
            { "g1", (uint)1 << 3},
            { "b2", (uint)1 << 4},
            { "d2", (uint)1 << 5},
            { "f2", (uint)1 << 6},
            { "h2", (uint)1 << 7},
            { "a3", (uint)1 << 8},
            { "c3", (uint)1 << 9},
            { "e3", (uint)1 << 10},
            { "g3", (uint)1 << 11},
            { "b4", (uint)1 << 12},
            { "d4", (uint)1 << 13},
            { "f4", (uint)1 << 14},
            { "h4", (uint)1 << 15},
            { "a5", (uint) 1 << 16},
            { "c5", (uint) 1 << 17},
            { "e5", (uint) 1 << 18},
            { "g5", (uint) 1 << 19},
            { "b6", (uint) 1 << 20},
            { "d6", (uint) 1 << 21},
            { "f6", (uint) 1 << 22},
            { "h6", (uint) 1 << 23},
            { "a7", (uint) 1 << 24},
            { "c7", (uint) 1 << 25},
            { "e7", (uint) 1 << 26},
            { "g7", (uint) 1 << 27},
            { "b8", (uint) 1 << 28},
            { "d8", (uint) 1 << 29},
            { "f8", (uint) 1 << 30},
            { "h8", (uint) 1 << 31}
        };

        public static Dictionary<string, uint> beatMask = new Dictionary<string, uint>()
        {
            { "a1", boardCellMask["c3"] },
            { "c1", boardCellMask["a3"] | boardCellMask["e3"] },
            { "e1", boardCellMask["c3"] | boardCellMask["g3"] },
            { "g1", boardCellMask["e3"] },
            { "b2", boardCellMask["d4"] },
            { "d2", boardCellMask["b4"] | boardCellMask["f4"] },
            { "f2", boardCellMask["d4"] | boardCellMask["h4"] },
            { "h2", boardCellMask["f4"] },
            { "a3", boardCellMask["c1"] | boardCellMask["c5"] },
            { "c3", boardCellMask["a1"] | boardCellMask["e1"] | boardCellMask["a5"] | boardCellMask["e5"] },
            { "e3", boardCellMask["c1"] | boardCellMask["g1"] | boardCellMask["c5"] | boardCellMask["g5"] },
            { "g3", boardCellMask["e1"] | boardCellMask["e5"] },
            { "b4", boardCellMask["d2"] | boardCellMask["d6"] },
            { "d4", boardCellMask["b2"] | boardCellMask["f2"] | boardCellMask["b6"] | boardCellMask["f6"] },
            { "f4", boardCellMask["d2"] | boardCellMask["h2"] | boardCellMask["d6"] | boardCellMask["h6"] },
            { "h4", boardCellMask["f2"] | boardCellMask["f6"] },
            { "a5", boardCellMask["c3"] | boardCellMask["c7"] },
            { "c5", boardCellMask["a3"] | boardCellMask["e3"] | boardCellMask["a7"] | boardCellMask["e7"] },
            { "e5", boardCellMask["c3"] | boardCellMask["g3"] | boardCellMask["c7"] | boardCellMask["g7"] },
            { "g5", boardCellMask["e3"] | boardCellMask["e7"] },
            { "b6", boardCellMask["d4"] | boardCellMask["d8"] },
            { "d6", boardCellMask["b4"] | boardCellMask["f4"] | boardCellMask["b8"] | boardCellMask["f8"] },
            { "f6", boardCellMask["d4"] | boardCellMask["h4"] | boardCellMask["d8"] | boardCellMask["h8"] },
            { "h6", boardCellMask["f4"] | boardCellMask["f8"] },
            { "a7", boardCellMask["c5"] },
            { "c7", boardCellMask["a5"] | boardCellMask["e5"] },
            { "e7", boardCellMask["c5"] | boardCellMask["g5"] },
            { "g7", boardCellMask["e5"] },
            { "b8", boardCellMask["d6"] },
            { "d8", boardCellMask["b6"] | boardCellMask["f6"] },
            { "f8", boardCellMask["d6"] | boardCellMask["h6"] },
            { "h8", boardCellMask["f6"] }
        };

        public static Dictionary<string, uint> firstCheckerMoveMask = new Dictionary<string, uint>()
        {
            { "a1", boardCellMask["b2"] },
            { "e1", boardCellMask["d2"] | boardCellMask["f2"] },
            { "g1", boardCellMask["f2"] | boardCellMask["h2"] },
            { "b2", boardCellMask["a3"] | boardCellMask["c3"] },
            { "d2", boardCellMask["c3"] | boardCellMask["e3"] },
            { "f2", boardCellMask["e3"] | boardCellMask["g3"] },
            { "h2", boardCellMask["g3"] },
            { "a3", boardCellMask["b4"] },
            { "c3", boardCellMask["b4"] | boardCellMask["d4"] },
            { "e3", boardCellMask["d4"] | boardCellMask["f4"] },
            { "g3", boardCellMask["f4"] | boardCellMask["h4"] },
            { "b4", boardCellMask["a5"] | boardCellMask["c5"] },
            { "d4", boardCellMask["c5"] | boardCellMask["e5"] },
            { "f4", boardCellMask["e5"] | boardCellMask["g5"] },
            { "h4", boardCellMask["g5"] },
            { "a5", boardCellMask["b6"] },
            { "c5", boardCellMask["b6"] | boardCellMask["d6"] },
            { "e5", boardCellMask["d6"] | boardCellMask["f6"] },
            { "g5", boardCellMask["f6"] | boardCellMask["h6"] },
            { "b6", boardCellMask["a7"] | boardCellMask["c7"] },
            { "d6", boardCellMask["c7"] | boardCellMask["e7"] },
            { "f6", boardCellMask["e7"] | boardCellMask["g7"] },
            { "h6", boardCellMask["g7"] },
            { "a7", boardCellMask["b8"] },
            { "c7", boardCellMask["b8"] | boardCellMask["d8"] },
            { "e7", boardCellMask["d8"] | boardCellMask["f8"] },
            { "g7", boardCellMask["f8"] | boardCellMask["h8"] },
            { "b8", 0 },
            { "d8", 0 },
            { "f8", 0 },
            { "h8", 0 }
        };

        public static Dictionary<string, uint> secondCheckerMoveMask = new Dictionary<string, uint>()
        {
            { "a1", 0 },
            { "c1", 0 },
            { "e1", 0 },
            { "g1", 0 },
            { "b2", boardCellMask["a1"] | boardCellMask["c1"] },
            { "d2", boardCellMask["c1"] | boardCellMask["e1"] },
            { "f2", boardCellMask["e1"] | boardCellMask["g1"]},
            { "h2", boardCellMask["g1"]},
            { "a3", boardCellMask["b2"]},
            { "c3", boardCellMask["b2"] | boardCellMask["d2"]},
            { "e3", boardCellMask["d2"] | boardCellMask["f2"]},
            { "g3", boardCellMask["f2"] | boardCellMask["h2"]},
            { "b4", boardCellMask["a3"] | boardCellMask["c3"]},
            { "d4", boardCellMask["c3"] | boardCellMask["e3"]},
            { "f4", boardCellMask["e3"] | boardCellMask["g3"]},
            { "h4", boardCellMask["g3"]},
            { "a5", boardCellMask["b4"]},
            { "c5", boardCellMask["b4"] | boardCellMask["d4"]},
            { "e5", boardCellMask["d4"] | boardCellMask["f4"]},
            { "g5", boardCellMask["f4"] | boardCellMask["h4"] },
            { "b6", boardCellMask["a5"] | boardCellMask["c5"] },
            { "d6", boardCellMask["c5"] | boardCellMask["e5"] },
            { "f6", boardCellMask["e5"] | boardCellMask["g5"]},
            { "h6", boardCellMask["g5"]},
            { "a7", boardCellMask["b6"] },
            { "c7", boardCellMask["b6"] | boardCellMask["d6"]},
            { "e7", boardCellMask["d6"] | boardCellMask["f6"]},
            { "g7", boardCellMask["f6"] | boardCellMask["h6"]},
            { "b8", boardCellMask["a7"] | boardCellMask["c7"]},
            { "d8", boardCellMask["c7"] | boardCellMask["e7"]},
            { "f8", boardCellMask["e7"] | boardCellMask["g7"]},
            { "h8", boardCellMask["g7"]}
        };
    }
}
