using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Masks
{
    [Flags]
    public enum BoardMask : uint
    {
        a1 = (uint)1 << 0,
        c1 = (uint)1 << 1,
        e1 = (uint)1 << 2,       
        g1 = (uint)1 << 3,
        b2 = (uint)1 << 4,
        d2 = (uint)1 << 5,
        f2 = (uint)1 << 6,
        h2 = (uint)1 << 7,
        a3 = (uint)1 << 8,
        c3 = (uint)1 << 9,
        e3 = (uint)1 << 10,
        g3 = (uint)1 << 11,
        b4 = (uint)1 << 12,
        d4 = (uint)1 << 13,
        f4 = (uint)1 << 14,
        h4 = (uint)1 << 15,
        a5 = (uint)1 << 16,
        c5 = (uint)1 << 17,
        e5 = (uint)1 << 18,
        g5 = (uint)1 << 19,
        b6 = (uint)1 << 20,
        d6 = (uint)1 << 21,
        f6 = (uint)1 << 22,
        h6 = (uint)1 << 23,
        a7 = (uint)1 << 24,
        c7 = (uint)1 << 25,
        e7 = (uint)1 << 26,
        g7 = (uint)1 << 27,
        b8 = (uint)1 << 28,
        d8 = (uint)1 << 29,
        f8 = (uint)1 << 30,
        h8 = (uint)1 << 31
    }
}
