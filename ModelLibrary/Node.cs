using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using ModelLibrary.Masks;

namespace ModelLibrary
{
    public class Node
    {
        private BoardCellMask _cellName;
        private Node _upperLeftNode;
        private Node _upperRightNode; 
        private Node _lowerLeftNode;
        private Node _lowerRightNode;

        private Checker _unit;

        public Node(BoardCellMask name) 
        {
            _cellName = name;
        }

        public Checker Unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }

        public BoardCellMask CellName { 
            get => _cellName; private set => _cellName = value; }

        public Node UpperLeftNode { get => _upperLeftNode; 
            /*private*/ set => _upperLeftNode = value; }
        public Node UpperRightNode { get => _upperRightNode; 
            /*private*/ set => _upperRightNode = value; }
        public Node LowerLeftNode { get => _lowerLeftNode; 
            /*private*/ set => _lowerLeftNode = value; }
        public Node LowerRightNode { get => _lowerRightNode; 
            /*private*/ set => _lowerRightNode = value; }

        public void SetNeighbours(Node upperLeftNode, Node upperRightNode,
            Node lowerLeftNode, Node lowerRightNode)
        {
            _upperLeftNode = upperLeftNode;
            _upperRightNode = upperRightNode;
            _lowerLeftNode = lowerLeftNode;
            _lowerRightNode = lowerRightNode;
        }

    }
}
