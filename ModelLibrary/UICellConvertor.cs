using ModelLibrary.Masks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class UICellConvertor
    {
        private const int NUMBER_OF_CELLS = 32;
        private readonly ViewCoordinate[] CELL_CCORDINATE = new ViewCoordinate[NUMBER_OF_CELLS]
        {
            new ViewCoordinate("a1", 7, 0),
            new ViewCoordinate("c1", 7, 2),
            new ViewCoordinate("e1", 7, 4),
            new ViewCoordinate("g1", 7, 6),
            new ViewCoordinate("b2", 6, 1),
            new ViewCoordinate("d2", 6, 3),
            new ViewCoordinate("f2", 6, 5),
            new ViewCoordinate("h2", 6, 7),
            new ViewCoordinate("a3", 5, 0),
            new ViewCoordinate("c3", 5, 2),
            new ViewCoordinate("e3", 5, 4),
            new ViewCoordinate("g3", 5, 6),
            new ViewCoordinate("b4", 4, 1),
            new ViewCoordinate("d4", 4, 3),
            new ViewCoordinate("f4", 4, 5),
            new ViewCoordinate("h4", 4, 7),
            new ViewCoordinate("a5", 3, 0),
            new ViewCoordinate("c5", 3, 2),
            new ViewCoordinate("e5", 3, 4),
            new ViewCoordinate("g5", 3, 6),
            new ViewCoordinate("b6", 2, 1),
            new ViewCoordinate("d6", 2, 3),
            new ViewCoordinate("f6", 2, 5),
            new ViewCoordinate("h6", 2, 7),
            new ViewCoordinate("a7", 1, 0),
            new ViewCoordinate("c7", 1, 2),
            new ViewCoordinate("e7", 1, 4),
            new ViewCoordinate("g7", 1, 6),
            new ViewCoordinate("b8", 0, 1),
            new ViewCoordinate("d8", 0, 3),
            new ViewCoordinate("f8", 0, 5),
            new ViewCoordinate("h8", 0, 7),
        };

        #region Fields

        private string[] _cellNames;
        private int _numberOfCells;

        public int NumberOfCells
        {
            get
            {
                return _numberOfCells;
            }
        }

        #endregion

        #region ctor

        public UICellConvertor()
        {
            _numberOfCells = NUMBER_OF_CELLS;
            _cellNames = new string[NUMBER_OF_CELLS];

            for (int i = 0; i < NUMBER_OF_CELLS; i++)
            {
                _cellNames[i] = CELL_CCORDINATE[i].Name;
            }
        }

        #endregion

        public string this[int index]
        {
            get
            {
                return _cellNames[index];
            }
        }

        public void GetCoordinatesByMask(BoardCellMask cellMask, out int vertical, out int horizontal)
        {
            vertical = -1;
            horizontal = -1;

            string name = cellMask.ToString();

            for (int i = 0; i < NUMBER_OF_CELLS; i++)
            {
                if (Equals(_cellNames[i], name))
                {
                    vertical = CELL_CCORDINATE[i].Vertical;
                    horizontal = CELL_CCORDINATE[i].Horizontal;
                }
            }
        }

        public void GetCoordinatesByName(string cellName, out int vertical, out int horizontal)
        {
            vertical = -1;
            horizontal = -1;

            for (int i = 0; i < NUMBER_OF_CELLS; i++)
            {
                if (Equals(_cellNames[i], cellName))
                {
                    vertical = CELL_CCORDINATE[i].Vertical;
                    horizontal = CELL_CCORDINATE[i].Horizontal;
                }
            }
        }

        public int GetVerticalByIndex(int index)
        {
            return CELL_CCORDINATE[index].Vertical;
        }
        public int GetHorizontalByIndex(int index)
        {
            return CELL_CCORDINATE[index].Horizontal;
        }

    }
}
