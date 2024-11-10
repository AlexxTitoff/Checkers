using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using ModelLibrary.Masks;

namespace ModelLibrary
{
    public sealed class FieldNodes
    {
        private static List<Node> _nodes;
        private static FieldNodes _instance;

        private FieldNodes()
        {
        }

        public static FieldNodes GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FieldNodes();
                _nodes = new List<Node>();
            }

            return _instance;
        }

        public Node this[BoardCellMask nodeName] // TODO: is it necessary?
        {
            get
            {
                Node result = null;

                if (_nodes.Count > 0 && ContainsNode(nodeName))
                {
                    TryGetIndexByName(nodeName, out int index);
                    result = _nodes[index];
                }

                return result;
            }
        }

        public Node this[int index]
        {
            get
            {
                Node result = null;

                if (_nodes.Count > 0 
                    && (index >=0 && index < _nodes.Count))
                {
                    result = _nodes[index];
                }

                return result;
            }
        }


        public bool TryGetIndexByName(BoardCellMask name, out int index)
        {
            bool result = false;
            index = -1;

            for (int i = 0; i < _nodes.Count; i++)
            {
                if (_nodes[i] != null && _nodes[i].CellName.Equals(name))
                {
                    index = i;
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool ContainsNode(BoardCellMask name)
        {
            bool result = false;

            for (int i = 0; i < _nodes.Count; i++)
            {
                if (_nodes[i].CellName.Equals(name))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool ContainsNode(string nameString)
        {
            bool result = false;

            for (int i = 0; i < _nodes.Count; i++)
            {
                if (_nodes[i].CellName.ToString().Equals(nameString))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void AddNode(Node node)
        {
            _nodes.Add(node);
        }

        public void SetUnit(BoardCellMask name, Checker unit)
        {
            if (!TryGetIndexByName(name, out int index))
            {
                throw new NotImplementedException();
            }
            
            _nodes[index].Unit = unit; 
        }

        public bool TrySetNeighbours(BoardCellMask name, Node upperLeftNode, Node upperRightNode,
            Node lowerLeftNode, Node lowerRightNode) 
        {
            bool result = false;

            if (TryGetIndexByName(name, out int index))
            {
                _nodes[index].UpperLeftNode = upperLeftNode;
                _nodes[index].UpperRightNode = upperRightNode;
                _nodes[index].LowerLeftNode = lowerLeftNode;
                _nodes[index].LowerRightNode = lowerRightNode;

                result = true;
            }

            return result;
        }
    }
}
