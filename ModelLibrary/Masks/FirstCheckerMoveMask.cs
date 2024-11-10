using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Masks
{
    [Flags]
    public enum FirstCheckerMoveMask : uint
    {
        a1 = BoardCellMask.b2,
        c1 = BoardCellMask.b2 | BoardCellMask.d2,
        e1 = BoardCellMask.d2 | BoardCellMask.f2,
        g1 = BoardCellMask.f2 | BoardCellMask.h2,
        b2 = BoardCellMask.a3 | BoardCellMask.c3,
        d2 = BoardCellMask.c3 | BoardCellMask.e3,
        f2 = BoardCellMask.e3 | BoardCellMask.g3,
        h2 = BoardCellMask.g3,
        a3 = BoardCellMask.b4,
        c3 = BoardCellMask.b4 | BoardCellMask.d4,
        e3 = BoardCellMask.d4 | BoardCellMask.f4,
        g3 = BoardCellMask.f4 | BoardCellMask.h4,
        b4 = BoardCellMask.a5 | BoardCellMask.c5,
        d4 = BoardCellMask.c5 | BoardCellMask.e5,
        f4 = BoardCellMask.e5 | BoardCellMask.g5,
        h4 = BoardCellMask.g5,
        a5 = BoardCellMask.b6,
        c5 = BoardCellMask.b6 | BoardCellMask.d6,
        e5 = BoardCellMask.d6 | BoardCellMask.f6,
        g5 = BoardCellMask.f6 | BoardCellMask.h6,
        b6 = BoardCellMask.a7 | BoardCellMask.c7,
        d6 = BoardCellMask.c7 | BoardCellMask.e7,
        f6 = BoardCellMask.e7 | BoardCellMask.g7,
        h6 = BoardCellMask.g7,
        a7 = BoardCellMask.b8,
        c7 = BoardCellMask.b8 | BoardCellMask.d8,
        e7 = BoardCellMask.d8 | BoardCellMask.f8,
        g7 = BoardCellMask.f8 | BoardCellMask.h8,
        b8 = 0,
        d8 = 0,
        f8 = 0,
        h8 = 0
    }
}
