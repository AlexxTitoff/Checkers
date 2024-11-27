using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Masks
{
    [Flags]
    public enum BeatMask : uint
    {
        a1 = BoardMask.c3,
        c1 = BoardMask.a3 | BoardMask.e3,
        e1 = BoardMask.c3 | BoardMask.g3,
        g1 = BoardMask.e3,
        b2 = BoardMask.d4,
        d2 = BoardMask.b4 | BoardMask.f4,
        f2 = BoardMask.d4 | BoardMask.h4,
        h2 = BoardMask.f4,
        a3 = BoardMask.c1 | BoardMask.c5,
        c3 = BoardMask.a1 | BoardMask.e1 | BoardMask.a5 | BoardMask.e5,
        e3 = BoardMask.c1 | BoardMask.g1 | BoardMask.c5 | BoardMask.g5,
        g3 = BoardMask.e1 | BoardMask.e5,
        b4 = BoardMask.d2 | BoardMask.d6,
        d4 = BoardMask.b2 | BoardMask.f2 | BoardMask.b6 | BoardMask.f6,
        f4 = BoardMask.d2 | BoardMask.h2 | BoardMask.d6 | BoardMask.h6,
        h4 = BoardMask.f2 | BoardMask.f6,
        a5 = BoardMask.c3 | BoardMask.c7,
        c5 = BoardMask.a3 | BoardMask.e3 | BoardMask.a7 | BoardMask.e7,
        e5 = BoardMask.c3 | BoardMask.g3 | BoardMask.c7 | BoardMask.g7,
        g5 = BoardMask.e3 | BoardMask.e7,
        b6 = BoardMask.d4 | BoardMask.d8,
        d6 = BoardMask.b4 | BoardMask.f4 | BoardMask.b8 | BoardMask.f8,
        f6 = BoardMask.d4 | BoardMask.h4 | BoardMask.d8 | BoardMask.h8,
        h6 = BoardMask.f4 | BoardMask.f8,
        a7 = BoardMask.c5,
        c7 = BoardMask.a5 | BoardMask.e5,
        e7 = BoardMask.c5 | BoardMask.g5,
        g7 = BoardMask.e5,
        b8 = BoardMask.d6,
        d8 = BoardMask.b6 | BoardMask.f6,
        f8 = BoardMask.d6 | BoardMask.h6,
        h8 = BoardMask.f6
    }
}
