﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ModelLibrary.Masks
{
    public class CellRelationCase
    {
        public string Name { get; private set; }
        public BeatMask Beat { get; private set; }
        public BoardMask BoardCell { get; private set; }
        public FirstCheckerMoveMask FirstCheckerMove { get; private set; }
        public SecondCheckerMoveMask SecondCheckerMove { get; private set; }

        public CellRelationCase(string name, BeatMask beat, BoardMask boardCell,
            FirstCheckerMoveMask firstCheckerMove, SecondCheckerMoveMask secondCheckerMove)
        {
            Name = name;
            Beat = beat;
            BoardCell = boardCell;
            FirstCheckerMove = firstCheckerMove;
            SecondCheckerMove = secondCheckerMove;
        }

    }
}
