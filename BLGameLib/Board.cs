using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using ModelLibrary.Masks;

namespace BLGameLib
{
    public class Board // TODO: Singleton???
    {
        public const int CELL_COUNT = 32;

        private CellRelationCase[] _cellRelations = new CellRelationCase[CELL_COUNT];

        public Board()
        {
            AddCellRelations();
        }

        public bool TryGetCellRelationCaseByValue(uint cellMaskValue, out CellRelationCase cellRelationCase)
        {
            bool result = false;
            cellRelationCase = null;

            for (int i = 0; i < CELL_COUNT; i++)
            {
                if ((uint)_cellRelations[i].BoardCell == cellMaskValue)
                {
                    cellRelationCase = _cellRelations[i];
                    result = true;
                    break;
                }
            }

            return result;
        }

        private void AddCellRelations()
        {
            for (int i = 0; i < CELL_COUNT; i++)
            {
                _cellRelations[i] = new CellRelationCase(
                    CellRelationBox.Names[i],
                    CellRelationBox.BeatMasks[i],
                    CellRelationBox.BoardMasks[i],
                    CellRelationBox.FirstCheckerMoveMasks[i],
                    CellRelationBox.SecondCheckerMoveMasks[i]);
            }
        }

        public bool TryGetMaskIndexByValue(uint value, out int index)
        {
            bool result = false;
            index = -1;

            for (int i = 0; i < CELL_COUNT; i++)
            {
                if ((uint)_cellRelations[i].BoardCell == value)
                {
                    index = i;
                    result = true;
                    break;
                }

            }

            return result;
        }

    }
}
