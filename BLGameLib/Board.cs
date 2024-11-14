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

        //private CellRelationCase[] _cellRelations = new CellRelationCase[CELL_COUNT];

        string[] _cells = new string[CELL_COUNT]
        {
            "a1", "c1", "e1", "g1", "b2", "d2", "f2", "h2", "a3", "c3", "e3", "g3", "b4", "d4", "f4", "h4", "a5",
            "c5", "e5", "g5", "b6", "d6", "f6", "h6", "a7", "c7", "e7", "g7", "b8", "d8", "f8", "h8"
        };

        //public Board()
        //{
        //    AddCellRelations();
        //}

        //public CellRelationSet this[int index]
        //{
        //    get
        //    {
        //        return _cellRelations[index];
        //    }
        //}

        public bool TryGetCellRelationCaseByValue(uint cellMaskValue, out string cellRelationCase)
        {
            bool result = false;
            cellRelationCase = string.Empty;

            foreach (var item in CellRelationState.boardCellMask)
            {
                if (item.Value == cellMaskValue)
                {
                    cellRelationCase = item.Key;
                    result = true;
                    break;
                }
            }

            return result;
        }

        //private void AddCellRelations()
        //{
            
        //    _cellRelations[0] = new CellRelationCase("a1", BeatMasks.a1, BoardCellMask.a1, 
        //        FirstCheckerMoveMask.a1, SecondCheckerMoveMask.a1);
        //    _cellRelations[1] = new CellRelationCase("c1", BeatMasks.c1, BoardCellMask.c1,
        //        FirstCheckerMoveMask.c1, SecondCheckerMoveMask.c1);
        //    _cellRelations[2] = new CellRelationCase("e1", BeatMasks.e1, BoardCellMask.e1,
        //        FirstCheckerMoveMask.e1, SecondCheckerMoveMask.e1);
        //    _cellRelations[3] = new CellRelationCase("g1", BeatMasks.g1, BoardCellMask.g1,
        //        FirstCheckerMoveMask.g1, SecondCheckerMoveMask.g1);

        //    _cellRelations[4] = new CellRelationCase("b2", BeatMasks.b2, BoardCellMask.b2,
        //        FirstCheckerMoveMask.b2, SecondCheckerMoveMask.b2);
        //    _cellRelations[5] = new CellRelationCase("d2", BeatMasks.d2, BoardCellMask.d2,
        //        FirstCheckerMoveMask.d2, SecondCheckerMoveMask.d2);
        //    _cellRelations[6] = new CellRelationCase("f2", BeatMasks.f2, BoardCellMask.f2,
        //        FirstCheckerMoveMask.f2, SecondCheckerMoveMask.f2);
        //    _cellRelations[7] = new CellRelationCase("h2", BeatMasks.h2, BoardCellMask.h2,
        //        FirstCheckerMoveMask.h2, SecondCheckerMoveMask.h2);

        //    _cellRelations[8] = new CellRelationCase("a3", BeatMasks.a3, BoardCellMask.a3,
        //        FirstCheckerMoveMask.a3, SecondCheckerMoveMask.a3);
        //    _cellRelations[9] = new CellRelationCase("c3", BeatMasks.c3, BoardCellMask.c3,
        //        FirstCheckerMoveMask.c3, SecondCheckerMoveMask.c3);
        //    _cellRelations[10] = new CellRelationCase("e3", BeatMasks.e3, BoardCellMask.e3,
        //        FirstCheckerMoveMask.e3, SecondCheckerMoveMask.e3);
        //    _cellRelations[11] = new CellRelationCase("g3", BeatMasks.g3, BoardCellMask.g3,
        //        FirstCheckerMoveMask.g3, SecondCheckerMoveMask.g3);
           
        //    _cellRelations[12] = new CellRelationCase("b4", BeatMasks.b4, BoardCellMask.b4,
        //        FirstCheckerMoveMask.b4, SecondCheckerMoveMask.b4);
        //    _cellRelations[13] = new CellRelationCase("d4", BeatMasks.d4, BoardCellMask.d4,
        //        FirstCheckerMoveMask.d4, SecondCheckerMoveMask.d4);
        //    _cellRelations[14] = new CellRelationCase("f4", BeatMasks.f4, BoardCellMask.f4,
        //        FirstCheckerMoveMask.f4, SecondCheckerMoveMask.f4);
        //    _cellRelations[15] = new CellRelationCase("h4", BeatMasks.h4, BoardCellMask.h4,
        //        FirstCheckerMoveMask.h4, SecondCheckerMoveMask.h4);

        //    _cellRelations[16] = new CellRelationCase("a5", BeatMasks.a5, BoardCellMask.a5,
        //        FirstCheckerMoveMask.a5, SecondCheckerMoveMask.a5);
        //    _cellRelations[17] = new CellRelationCase("c5", BeatMasks.c5, BoardCellMask.c5,
        //        FirstCheckerMoveMask.c5, SecondCheckerMoveMask.c5);
        //    _cellRelations[18] = new CellRelationCase("e5", BeatMasks.e5, BoardCellMask.e5,
        //        FirstCheckerMoveMask.e5, SecondCheckerMoveMask.e5);
        //    _cellRelations[19] = new CellRelationCase("g5", BeatMasks.g5, BoardCellMask.g5,
        //        FirstCheckerMoveMask.g5, SecondCheckerMoveMask.g5);

        //    _cellRelations[20] = new CellRelationCase("b6", BeatMasks.b6, BoardCellMask.b6,
        //        FirstCheckerMoveMask.b6, SecondCheckerMoveMask.b6);
        //    _cellRelations[21] = new CellRelationCase("d6", BeatMasks.d6, BoardCellMask.d6,
        //        FirstCheckerMoveMask.d6, SecondCheckerMoveMask.d6);
        //    _cellRelations[22] = new CellRelationCase("f6", BeatMasks.f6, BoardCellMask.f6,
        //        FirstCheckerMoveMask.f6, SecondCheckerMoveMask.f6);
        //    _cellRelations[23] = new CellRelationCase("h6", BeatMasks.h6, BoardCellMask.h6,
        //        FirstCheckerMoveMask.h6, SecondCheckerMoveMask.h6);

        //    _cellRelations[24] = new CellRelationCase("a7", BeatMasks.a7, BoardCellMask.a7,
        //        FirstCheckerMoveMask.a7, SecondCheckerMoveMask.a7);
        //    _cellRelations[25] = new CellRelationCase("c7", BeatMasks.c7, BoardCellMask.c7,
        //        FirstCheckerMoveMask.c7, SecondCheckerMoveMask.c7);
        //    _cellRelations[26] = new CellRelationCase("e7", BeatMasks.e7, BoardCellMask.e7,
        //        FirstCheckerMoveMask.e7, SecondCheckerMoveMask.e7);
        //    _cellRelations[27] = new CellRelationCase("g7", BeatMasks.g7, BoardCellMask.g7,
        //        FirstCheckerMoveMask.g7, SecondCheckerMoveMask.g7);

        //    _cellRelations[28] = new CellRelationCase("b8", BeatMasks.b8, BoardCellMask.b8,
        //        FirstCheckerMoveMask.b8, SecondCheckerMoveMask.b8);
        //    _cellRelations[29] = new CellRelationCase("d8", BeatMasks.d8, BoardCellMask.d8,
        //        FirstCheckerMoveMask.d8, SecondCheckerMoveMask.d8);
        //    _cellRelations[30] = new CellRelationCase("f8", BeatMasks.f8, BoardCellMask.f8,
        //        FirstCheckerMoveMask.f8, SecondCheckerMoveMask.f8);
        //    _cellRelations[31] = new CellRelationCase("h8", BeatMasks.h8, BoardCellMask.h8,
        //        FirstCheckerMoveMask.h8, SecondCheckerMoveMask.h8);
        //}
        
        public bool TryGetMaskIndexByValue(uint value, out string key)
        {
            bool result = false;
            key = string.Empty;

            foreach (var item in CellRelationState.boardCellMask)
            {
                if (item.Value == value)
                {
                    key = item.Key;
                    result = true;
                    break;
                }
            }

            return result;
        }

        // TODO: member-function + simplify
        public static bool TryGetMaskValueByName(string name, Type mask, out uint value)
        {
            bool result = false;
            value = 0;
            string[] masks = Enum.GetNames(mask).ToArray();
            uint[] values = (uint[])Enum.GetValues(mask);

            for (int i = 0; i < masks.Length; i++) // TODO: CELL_COUNT
            {
                if (masks[i].Equals(name))
                {
                    value = values[i];
                    result = true;
                    break;
                }

            }

            return result;
        }


    }
}
