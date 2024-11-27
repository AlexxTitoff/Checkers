using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModelLibrary;
using ModelLibrary.Masks;

namespace BLGameLib
{
    public class StartBuilder
    {
        private Game _destination;

        public StartBuilder(Game destination)
        {
            _destination = destination;
        }

        public void AddStartCheckers() // TODO: flexibility
        {
            _destination.FirstPlayerUnitsIntegralCode =
                (uint)BoardMask.a3 + (uint)BoardMask.c3 + (uint)BoardMask.e3 +
                (uint)BoardMask.g3 + (uint)BoardMask.b2 + (uint)BoardMask.d2 +
                (uint)BoardMask.f2 + (uint)BoardMask.h2 + (uint)BoardMask.a1 +
                (uint)BoardMask.c1 + (uint)BoardMask.e1 + (uint)BoardMask.g1;

            _destination.SecondPlayerUnitsIntegralCode =
                (uint)BoardMask.b6 + (uint)BoardMask.d6 + (uint)BoardMask.f6 +
                (uint)BoardMask.h6 + (uint)BoardMask.a7 + (uint)BoardMask.c7 +
                (uint)BoardMask.e7 + (uint)BoardMask.g7 + (uint)BoardMask.b8 +
                (uint)BoardMask.d8 + (uint)BoardMask.f8 + (uint)BoardMask.h8;
        }

    }
}
