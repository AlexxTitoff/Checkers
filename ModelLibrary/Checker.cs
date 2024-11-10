using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModelLibrary.Masks;

namespace ModelLibrary
{
    public class Checker
    {
        #region Fields

        //private byte _x; //Horizontal coordinate
        //private byte _y; //Vertical coordinate
        
        protected Node _checkerNode;
        protected readonly FieldNodes _fieldNodes;

        //internal byte X
        //{
        //    get
        //    {
        //        return _x;
        //    }
        //    set
        //    {
        //        _x = value;
        //    }
        //}

        //internal byte Y
        //{
        //    get
        //    {
        //        return _y;
        //    }
        //    set
        //    {
        //        _y = value;
        //    }
        //}

        public Node CheckerNode
        {
            get 
            { 
                return _checkerNode; 
            }
            private set
            {
                _checkerNode = value;
            }
        }

        #endregion

        #region ctor

        //internal Checker() : this(0, 0)
        //{
        //}

        //internal Checker(byte x, byte y)
        //{
        //    _x = x;
        //    _y = y;
        //}

        public Checker(FieldNodes fieldNodes, BoardCellMask nodeName)
        {
            _fieldNodes = fieldNodes;
            _checkerNode = _fieldNodes[nodeName];
        }

        #endregion

        //public virtual bool TryMove(string startCellName, string destinationCellName)
        //{
        //    _x += deltaX;
        //    _y += deltaY;

        //    return true;
        //}

        public virtual void TryMove(Direction direction)
        {
            switch (direction)
            {
                case Direction.UpperLeft:
                    _checkerNode = _checkerNode.UpperLeftNode;
                    break;
                case Direction.UpperRight:
                    _checkerNode.UpperRightNode = _checkerNode;
                    break;
                case Direction.LowerLeft:
                    _checkerNode = _checkerNode.LowerLeftNode;
                    break;
                default:
                    _checkerNode = _checkerNode.LowerRightNode;
                    break;
            }
        }
    }
}
