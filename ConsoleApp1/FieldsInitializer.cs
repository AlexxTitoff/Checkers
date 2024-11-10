using System;
using System.Collections.Generic;

using ModelLibrary;
using ModelLibrary.Masks;

namespace ConsoleUILib
{
    public sealed class FieldsInitializer
    {
        private FieldNodes _destination;

        public FieldsInitializer(FieldNodes destination)
        {
            _destination = destination;
            AddItems();
            SetNeighbours();
        }

        private void AddItems()
        {
            foreach (var item in (BoardCellMask[])Enum.GetValues(typeof(BoardCellMask)))
            {
                _destination.AddNode(new Node(item));
            }
            
        }

        private void SetNeighbours()
        {
            _destination.TrySetNeighbours(BoardCellMask.a1,
                null, _destination[BoardCellMask.b2],
                null, null);
            _destination.TrySetNeighbours(BoardCellMask.c1,
                _destination[BoardCellMask.b2], _destination[BoardCellMask.d2], 
                null, null);
            _destination.TrySetNeighbours(BoardCellMask.e1,
                _destination[BoardCellMask.d2], _destination[BoardCellMask.f2],
                null, null);
            _destination.TrySetNeighbours(BoardCellMask.g1,
                _destination[BoardCellMask.f2], _destination[BoardCellMask.h2],
                null, null);

            _destination.TrySetNeighbours(BoardCellMask.b2,
                _destination[BoardCellMask.a3], _destination[BoardCellMask.c3],
                _destination[BoardCellMask.a1], _destination[BoardCellMask.c1]);
            _destination.TrySetNeighbours(BoardCellMask.d2,
                _destination[BoardCellMask.c3], _destination[BoardCellMask.e3],
                _destination[BoardCellMask.c1], _destination[BoardCellMask.e1]);
            _destination.TrySetNeighbours(BoardCellMask.f2,
                _destination[BoardCellMask.e3], _destination[BoardCellMask.g3],
                _destination[BoardCellMask.c1], _destination[BoardCellMask.g1]); 
            _destination.TrySetNeighbours(BoardCellMask.h2,
                _destination[BoardCellMask.g3], null,
                _destination[BoardCellMask.g1], null);

            _destination.TrySetNeighbours(BoardCellMask.a3,
                null, _destination[BoardCellMask.b4],
                null, _destination[BoardCellMask.b2]);
            _destination.TrySetNeighbours(BoardCellMask.c3,
                _destination[BoardCellMask.b4], _destination[BoardCellMask.d4],
                _destination[BoardCellMask.b2], _destination[BoardCellMask.d2]);
            _destination.TrySetNeighbours(BoardCellMask.e3,
                _destination[BoardCellMask.d4], _destination[BoardCellMask.f4],
                _destination[BoardCellMask.d2], _destination[BoardCellMask.f2]);
            _destination.TrySetNeighbours(BoardCellMask.g3,
                _destination[BoardCellMask.f4], _destination[BoardCellMask.h4],
                _destination[BoardCellMask.f2], _destination[BoardCellMask.h2]);

            _destination.TrySetNeighbours(BoardCellMask.b4,
                _destination[BoardCellMask.a5], _destination[BoardCellMask.c5],
                _destination[BoardCellMask.a3], _destination[BoardCellMask.c3]);
            _destination.TrySetNeighbours(BoardCellMask.d4,
                _destination[BoardCellMask.c5], _destination[BoardCellMask.e5],
                _destination[BoardCellMask.c3], _destination[BoardCellMask.e3]);
            _destination.TrySetNeighbours(BoardCellMask.f4,
                _destination[BoardCellMask.e5], _destination[BoardCellMask.g5],
                _destination[BoardCellMask.e3], _destination[BoardCellMask.g3]);
            _destination.TrySetNeighbours(BoardCellMask.h4,
                _destination[BoardCellMask.g5], null,
                _destination[BoardCellMask.g3], null);

            _destination.TrySetNeighbours(BoardCellMask.a5,
                null, _destination[BoardCellMask.b6],
                null, _destination[BoardCellMask.b4]);
            _destination.TrySetNeighbours(BoardCellMask.c5,
                _destination[BoardCellMask.b6], _destination[BoardCellMask.d6],
                _destination[BoardCellMask.b4], _destination[BoardCellMask.d4]);
            _destination.TrySetNeighbours(BoardCellMask.e5,
                _destination[BoardCellMask.d6], _destination[BoardCellMask.f6],
                _destination[BoardCellMask.d4], _destination[BoardCellMask.f4]);
            _destination.TrySetNeighbours(BoardCellMask.g5,
                _destination[BoardCellMask.f6], _destination[BoardCellMask.h6],
                _destination[BoardCellMask.f4], _destination[BoardCellMask.h4]);

            _destination.TrySetNeighbours(BoardCellMask.b6,
                _destination[BoardCellMask.a7], _destination[BoardCellMask.c7],
                _destination[BoardCellMask.a5], _destination[BoardCellMask.c5]);
            _destination.TrySetNeighbours(BoardCellMask.d6,
                _destination[BoardCellMask.c7], _destination[BoardCellMask.e7],
                _destination[BoardCellMask.c5], _destination[BoardCellMask.e5]);
            _destination.TrySetNeighbours(BoardCellMask.f6,
                _destination[BoardCellMask.e7], _destination[BoardCellMask.g7],
                _destination[BoardCellMask.e5], _destination[BoardCellMask.g5]);
            _destination.TrySetNeighbours(BoardCellMask.h4,
                _destination[BoardCellMask.g7], null,
                _destination[BoardCellMask.g5], null);

            _destination.TrySetNeighbours(BoardCellMask.a7,
                null, _destination[BoardCellMask.b8],
                null, _destination[BoardCellMask.b6]);
            _destination.TrySetNeighbours(BoardCellMask.c7,
                _destination[BoardCellMask.b8], _destination[BoardCellMask.d8],
                _destination[BoardCellMask.b6], _destination[BoardCellMask.d6]);
            _destination.TrySetNeighbours(BoardCellMask.e7,
                _destination[BoardCellMask.d8], _destination[BoardCellMask.f8],
                _destination[BoardCellMask.d6], _destination[BoardCellMask.f6]);
            _destination.TrySetNeighbours(BoardCellMask.g7,
                _destination[BoardCellMask.f8], _destination[BoardCellMask.h8],
                _destination[BoardCellMask.f6], _destination[BoardCellMask.h6]);

            _destination.TrySetNeighbours(BoardCellMask.b8,
                null, null,
                _destination[BoardCellMask.a7], _destination[BoardCellMask.c7]);
            _destination.TrySetNeighbours(BoardCellMask.d8,
                null, null,
                _destination[BoardCellMask.c7], _destination[BoardCellMask.e7]);
            _destination.TrySetNeighbours(BoardCellMask.f8,
                null, null,
                _destination[BoardCellMask.e7], _destination[BoardCellMask.g7]);
            _destination.TrySetNeighbours(BoardCellMask.h8,
                null, null,
                _destination[BoardCellMask.g7], null);
        }

    }
}
