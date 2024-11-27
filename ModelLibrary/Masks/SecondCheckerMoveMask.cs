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
        b2 = BoardMask.a1 | BoardMask.c1,
        d2 = BoardMask.c1 | BoardMask.e1,
        f2 = BoardMask.e1 | BoardMask.g1,
        h2 = BoardMask.g1,
        a3 = BoardMask.b2,
        c3 = BoardMask.b2 | BoardMask.d2,
        e3 = BoardMask.d2 | BoardMask.f2,
        g3 = BoardMask.f2 | BoardMask.h2,
        b4 = BoardMask.a3 | BoardMask.c3,
        d4 = BoardMask.c3 | BoardMask.e3,
        f4 = BoardMask.e3 | BoardMask.g3,
        h4 = BoardMask.g3,
        a5 = BoardMask.b4,
        c5 = BoardMask.b4 | BoardMask.d4,
        e5 = BoardMask.d4 | BoardMask.f4,
        g5 = BoardMask.f4 | BoardMask.h4,
        b6 = BoardMask.a5 | BoardMask.c5,
        d6 = BoardMask.c5 | BoardMask.e5,
        f6 = BoardMask.e5 | BoardMask.g5,
        h6 = BoardMask.g5,
        a7 = BoardMask.b6,
        c7 = BoardMask.b6 | BoardMask.d6,
        e7 = BoardMask.d6 | BoardMask.f6,
        g7 = BoardMask.f6 | BoardMask.h6,
        b8 = BoardMask.a7 | BoardMask.c7,
        d8 = BoardMask.c7 | BoardMask.e7,
        f8 = BoardMask.e7 | BoardMask.g7,
        h8 = BoardMask.g7,
    }
}
