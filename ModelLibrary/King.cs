using ModelLibrary.Masks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class King : Checker
    {
        #region ctor

        public King(FieldNodes fieldNodes, BoardCellMask nodeName) : base(fieldNodes, nodeName)
        {
        }

        #endregion

        //internal override void Move(byte deltaX, byte deltaY) //TODO
        //{
        //    //_x += deltaX;
        //    //_y += deltaY;
        //}

    }
}
