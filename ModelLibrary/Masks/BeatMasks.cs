using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Masks
{
    [Flags]
    public enum BeatMasks : uint
    {
        a1 = BoardCellMask.c3,
        c1 = BoardCellMask.a3 | BoardCellMask.e3,
        e1 = BoardCellMask.c3 | BoardCellMask.g3,
        g1 = BoardCellMask.e3,
        b2 = BoardCellMask.d4,
        d2 = BoardCellMask.b4 | BoardCellMask.f4,
        f2 = BoardCellMask.d4 | BoardCellMask.h4,
        h2 = BoardCellMask.f4,
        a3 = BoardCellMask.c1 | BoardCellMask.c5,
        c3 = BoardCellMask.a1 | BoardCellMask.e1 | BoardCellMask.a5 | BoardCellMask.e5,
        e3 = BoardCellMask.c1 | BoardCellMask.g1 | BoardCellMask.c5 | BoardCellMask.g5,
        g3 = BoardCellMask.e1 | BoardCellMask.e5,
        b4 = BoardCellMask.d2 | BoardCellMask.d6,
        d4 = BoardCellMask.b2 | BoardCellMask.f2 | BoardCellMask.b6 | BoardCellMask.f6,
        f4 = BoardCellMask.d2 | BoardCellMask.h2 | BoardCellMask.d6 | BoardCellMask.h6,
        h4 = BoardCellMask.f2 | BoardCellMask.f6,
        a5 = BoardCellMask.c3 | BoardCellMask.c7,
        c5 = BoardCellMask.a3 | BoardCellMask.e3 | BoardCellMask.a7 | BoardCellMask.e7,
        e5 = BoardCellMask.c3 | BoardCellMask.g3 | BoardCellMask.c7 | BoardCellMask.g7,
        g5 = BoardCellMask.e3 | BoardCellMask.e7,
        b6 = BoardCellMask.d4 | BoardCellMask.d8,
        d6 = BoardCellMask.b4 | BoardCellMask.f4 | BoardCellMask.b8 | BoardCellMask.f8,
        f6 = BoardCellMask.d4 | BoardCellMask.h4 | BoardCellMask.d8 | BoardCellMask.h8,
        h6 = BoardCellMask.f4 | BoardCellMask.f8,
        a7 = BoardCellMask.c5,
        c7 = BoardCellMask.a5 | BoardCellMask.e5,
        e7 = BoardCellMask.c5 | BoardCellMask.g5,
        g7 = BoardCellMask.e5,
        b8 = BoardCellMask.d6,
        d8 = BoardCellMask.b6 | BoardCellMask.f6,
        f8 = BoardCellMask.d6 | BoardCellMask.h6,
        h8 = BoardCellMask.f6
    }
}
