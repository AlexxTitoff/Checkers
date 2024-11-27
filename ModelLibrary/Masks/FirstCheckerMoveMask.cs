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
        a1 = BoardMask.b2,
        c1 = BoardMask.b2 | BoardMask.d2,
        e1 = BoardMask.d2 | BoardMask.f2,
        g1 = BoardMask.f2 | BoardMask.h2,
        b2 = BoardMask.a3 | BoardMask.c3,
        d2 = BoardMask.c3 | BoardMask.e3,
        f2 = BoardMask.e3 | BoardMask.g3,
        h2 = BoardMask.g3,
        a3 = BoardMask.b4,
        c3 = BoardMask.b4 | BoardMask.d4,
        e3 = BoardMask.d4 | BoardMask.f4,
        g3 = BoardMask.f4 | BoardMask.h4,
        b4 = BoardMask.a5 | BoardMask.c5,
        d4 = BoardMask.c5 | BoardMask.e5,
        f4 = BoardMask.e5 | BoardMask.g5,
        h4 = BoardMask.g5,
        a5 = BoardMask.b6,
        c5 = BoardMask.b6 | BoardMask.d6,
        e5 = BoardMask.d6 | BoardMask.f6,
        g5 = BoardMask.f6 | BoardMask.h6,
        b6 = BoardMask.a7 | BoardMask.c7,
        d6 = BoardMask.c7 | BoardMask.e7,
        f6 = BoardMask.e7 | BoardMask.g7,
        h6 = BoardMask.g7,
        a7 = BoardMask.b8,
        c7 = BoardMask.b8 | BoardMask.d8,
        e7 = BoardMask.d8 | BoardMask.f8,
        g7 = BoardMask.f8 | BoardMask.h8,
        b8 = 0,
        d8 = 0,
        f8 = 0,
        h8 = 0
    }
}
