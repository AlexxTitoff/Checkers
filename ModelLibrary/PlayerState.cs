using ModelLibrary.Masks;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class PlayerState // TODO: PlayerState or ...
    {
        private const int INITIAL_NUMBER_OF_UNITS = 12; // TODO: flexibility

        #region Fields

        private int _playerId; // 1 = Whites (FirstPlayer), 2 = Blacks (SecondPlayer)
        private int _numberOfUnits;
        private uint _unitsIntegralCode;

        public int NumberOfUnits
        {
            get
            {
                return _numberOfUnits;
            }
            set
            {
                _numberOfUnits = value;
            }
        }

        public uint UnitsIntegralCode
        {
            get
            {
                return _unitsIntegralCode;
            }
            set
            {
                _unitsIntegralCode = value;
            }
        }

        public int PlayerId { get { return _playerId; } }

        #endregion

        #region ctor

        public PlayerState(int playerId) // TODO: remove playerId ?????
        {
            _numberOfUnits = INITIAL_NUMBER_OF_UNITS;
            _playerId = playerId;
        }

        #endregion

    }
}
