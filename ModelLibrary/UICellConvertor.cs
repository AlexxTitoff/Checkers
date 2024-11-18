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
        private readonly CellView[] CELL_CCORDINATE = new CellView[NUMBER_OF_CELLS]
        {
            new CellView("a1", 7, 0),
            new CellView("c1", 7, 2),
            new CellView("e1", 7, 4),
            new CellView("g1", 7, 6),
            new CellView("b2", 6, 1),
            new CellView("d2", 6, 3),
            new CellView("f2", 6, 5),
            new CellView("h2", 6, 7),
            new CellView("a3", 5, 0),
            new CellView("c3", 5, 2),
            new CellView("e3", 5, 4),
            new CellView("g3", 5, 6),
            new CellView("b4", 4, 1),
            new CellView("d4", 4, 3),
            new CellView("f4", 4, 5),
            new CellView("h4", 4, 7),
            new CellView("a5", 3, 0),
            new CellView("c5", 3, 2),
            new CellView("e5", 3, 4),
            new CellView("g5", 3, 6),
            new CellView("b6", 2, 1),
            new CellView("d6", 2, 3),
            new CellView("f6", 2, 5),
            new CellView("h6", 2, 7),
            new CellView("a7", 1, 0),
            new CellView("c7", 1, 2),
            new CellView("e7", 1, 4),
            new CellView("g7", 1, 6),
            new CellView("b8", 0, 1),
            new CellView("d8", 0, 3),
            new CellView("f8", 0, 5),
            new CellView("h8", 0, 7),
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

        public string this[int index] // 0 reference ???
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
