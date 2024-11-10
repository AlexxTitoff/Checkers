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
        //private const int INITIAL_NUMBER_OF_UNITS = 12;
        private Game _destination;

        public StartBuilder(Game destination)
        {
            _destination = destination;
        }

        public void AddCheckers(FieldNodes fieldNodes) // TODO: flexibility
        {
            _destination[1, 0] = new Checker(fieldNodes, BoardCellMask.a3);
            _destination[1, 1] = new Checker(fieldNodes, BoardCellMask.c3);
            _destination[1, 2] = new Checker(fieldNodes, BoardCellMask.e3);
            _destination[1, 3] = new Checker(fieldNodes, BoardCellMask.g3);
            _destination[1, 4] = new Checker(fieldNodes, BoardCellMask.b2);
            _destination[1, 5] = new Checker(fieldNodes, BoardCellMask.d2);
            _destination[1, 6] = new Checker(fieldNodes, BoardCellMask.f2);
            _destination[1, 7] = new Checker(fieldNodes, BoardCellMask.h2);
            _destination[1, 8] = new Checker(fieldNodes, BoardCellMask.a1);
            _destination[1, 9] = new Checker(fieldNodes, BoardCellMask.c1);
            _destination[1, 10] = new Checker(fieldNodes, BoardCellMask.e1);
            _destination[1, 11] = new Checker(fieldNodes, BoardCellMask.g1);

            _destination.FirstPlayerUnitsIntegralCode =
                (uint)BoardCellMask.a3 + (uint)BoardCellMask.c3 + (uint)BoardCellMask.e3 +
                (uint)BoardCellMask.g3 + (uint)BoardCellMask.b2 + (uint)BoardCellMask.d2 +
                (uint)BoardCellMask.f2 + (uint)BoardCellMask.h2 + (uint)BoardCellMask.a1 +
                (uint)BoardCellMask.c1 + (uint)BoardCellMask.e1 + (uint)BoardCellMask.g1;


            _destination[2, 0] = new Checker(fieldNodes, BoardCellMask.b6);
            _destination[2, 1] = new Checker(fieldNodes, BoardCellMask.d6);
            _destination[2, 2] = new Checker(fieldNodes, BoardCellMask.f6);
            _destination[2, 3] = new Checker(fieldNodes, BoardCellMask.h6);
            _destination[2, 4] = new Checker(fieldNodes, BoardCellMask.a7);
            _destination[2, 5] = new Checker(fieldNodes, BoardCellMask.c7);
            _destination[2, 6] = new Checker(fieldNodes, BoardCellMask.e7);
            _destination[2, 7] = new Checker(fieldNodes, BoardCellMask.g7);
            _destination[2, 8] = new Checker(fieldNodes, BoardCellMask.b8);
            _destination[2, 9] = new Checker(fieldNodes, BoardCellMask.d8);
            _destination[2, 10] = new Checker(fieldNodes, BoardCellMask.f8);
            _destination[2, 11] = new Checker(fieldNodes, BoardCellMask.h8);

            _destination.SecondPlayerUnitsIntegralCode =
                (uint)BoardCellMask.b6 + (uint)BoardCellMask.d6 + (uint)BoardCellMask.f6 +
                (uint)BoardCellMask.h6 + (uint)BoardCellMask.a7 + (uint)BoardCellMask.c7 +
                (uint)BoardCellMask.e7 + (uint)BoardCellMask.g7 + (uint)BoardCellMask.b8 +
                (uint)BoardCellMask.d8 + (uint)BoardCellMask.f8 + (uint)BoardCellMask.h8;
        }

        public void AddCheckerToNodeLinks(FieldNodes fieldNodes)
        {

        }
    }
}
