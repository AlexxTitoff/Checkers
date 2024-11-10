using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Masks
{
    [Flags]
    public enum SecondCheckerMoveMask : uint
    {
        a1 = 0,
        c1 = 0,
        e1 = 0,
        g1 = 0,
        b2 = BoardCellMask.a1 | BoardCellMask.c1,
        d2 = BoardCellMask.c1 | BoardCellMask.e1,
        f2 = BoardCellMask.e1 | BoardCellMask.g1,
        h2 = BoardCellMask.g1,
        a3 = BoardCellMask.b2,
        c3 = BoardCellMask.b2 | BoardCellMask.d2,
        e3 = BoardCellMask.d2 | BoardCellMask.f2,
        g3 = BoardCellMask.f2 | BoardCellMask.h2,
        b4 = BoardCellMask.a3 | BoardCellMask.c3,
        d4 = BoardCellMask.c3 | BoardCellMask.e3,
        f4 = BoardCellMask.e3 | BoardCellMask.g3,
        h4 = BoardCellMask.g3,
        a5 = BoardCellMask.b4,
        c5 = BoardCellMask.b4 | BoardCellMask.d4,
        e5 = BoardCellMask.d4 | BoardCellMask.f4,
        g5 = BoardCellMask.f4 | BoardCellMask.h4,
        b6 = BoardCellMask.a5 | BoardCellMask.c5,
        d6 = BoardCellMask.c5 | BoardCellMask.e5,
        f6 = BoardCellMask.e5 | BoardCellMask.g5,
        h6 = BoardCellMask.g5,
        a7 = BoardCellMask.b6,
        c7 = BoardCellMask.b6 | BoardCellMask.d6,
        e7 = BoardCellMask.d6 | BoardCellMask.f6,
        g7 = BoardCellMask.f6 | BoardCellMask.h6,
        b8 = BoardCellMask.a7 | BoardCellMask.c7,
        d8 = BoardCellMask.c7 | BoardCellMask.e7,
        f8 = BoardCellMask.e7 | BoardCellMask.g7,
        h8 = BoardCellMask.g7,
    }
}
