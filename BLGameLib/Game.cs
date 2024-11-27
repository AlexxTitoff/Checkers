using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using ModelLibrary;
using ModelLibrary.Masks;
using System.Reflection;
using System.Xml.Linq;

namespace BLGameLib
{
    public class Game
    {
        #region Constants

        public static Random rnd = new Random(); 
        public const int CODE_LENGTH = 32;

        #endregion

        #region Fields

        private bool _isFirstPlayerTurn; //Determines, if the turn of move in the game is Whites'(true)
        private PlayerState _firstPlayerFigures;
        private PlayerState _secondPlayerFigures;
        private Board _maskConverter;

        public uint FirstPlayerUnitsIntegralCode
        {
            get
            {
                return _firstPlayerFigures.UnitsIntegralCode;
            }
            set
            {
                _firstPlayerFigures.UnitsIntegralCode = value;
            }
        }

        public uint SecondPlayerUnitsIntegralCode
        {
            get
            {
                return _secondPlayerFigures.UnitsIntegralCode;
            }
            set
            {
                _secondPlayerFigures.UnitsIntegralCode = value;
            }
        }


        public bool IsFirstPlayerTurn
        {
            get
            {
                return _isFirstPlayerTurn;
            }
            set
            {
                _isFirstPlayerTurn = value;
            }
        }

        #endregion

        #region ctor

        public Game()
        {
            _firstPlayerFigures = new PlayerState(1);
            _secondPlayerFigures = new PlayerState(2);
            _isFirstPlayerTurn = true;
            _maskConverter = new Board();

            Initialize();
        }

        #endregion

        public void Initialize()
        {
            StartBuilder source = new StartBuilder(this);
            source.AddStartCheckers();
        }

        public void ChangeTurn()
        {
            _isFirstPlayerTurn = !(_isFirstPlayerTurn);
        }

        public int GetIndexByCode(uint code)
        {
            _maskConverter.TryGetMaskIndexByValue(code, out int result);

            return result;
        }

        #region RandomMoveMethods

        public static List<uint> ToSingleCodeList(uint code) // Добавить такие поля List в CellRelationCase ???
        {
            var result = new List<uint>(CODE_LENGTH);
            uint singleCode = 0;

            for (int i = 0; i < CODE_LENGTH; i++)
            {
                singleCode = code & (uint)1 << i;

                if (singleCode != 0)
                {
                    result.Add(singleCode);
                }
            }

            return result;
        }

        public static uint GetRandomValue(List<uint> valueList)
        {
            return valueList[rnd.Next(0, valueList.Count)];
        }

        public bool TryGetRandomMoveIndexes(out int startCellIndex, out int destinationCellIndex)
        {
            uint startCellValue = 0;
            uint destinationCellValue = 0;
            startCellIndex = -1;
            destinationCellIndex = -1;

            return (TryRandomMoveFigure(out startCellValue, out destinationCellValue)
                && _maskConverter.TryGetMaskIndexByValue(startCellValue, out startCellIndex)
                && _maskConverter.TryGetMaskIndexByValue(destinationCellValue, out destinationCellIndex));
        }

        public bool TryRandomMoveFigure(out uint startCellValue, out uint destinationCellValue)
        {
            bool result = false;
            TryGetFinalValues(out startCellValue, out destinationCellValue);

            if (IsFirstPlayerTurn)
            {
                FirstPlayerUnitsIntegralCode -= startCellValue;
                FirstPlayerUnitsIntegralCode += destinationCellValue;
            }
            else
            {
                SecondPlayerUnitsIntegralCode -= startCellValue;
                SecondPlayerUnitsIntegralCode += destinationCellValue;
            }

            ChangeTurn();
            result = true;


            return result;
        }

        private uint GetRandomMoveDestinationCode(uint cellValue)
        {
            uint destinationCode = 0;

            if (_maskConverter.TryGetCellRelationCaseByValue(cellValue, out CellRelationCase cellRelationCase))
            {
                if (IsFirstPlayerTurn)
                {
                    destinationCode = (uint)cellRelationCase.FirstCheckerMove;
                }
                else
                {
                    destinationCode = (uint)cellRelationCase.SecondCheckerMove;
                }
            }

            return destinationCode;
        }

        private bool TryGetFinalValues(out uint startCellValue, out uint destinationCellValue)
        {
            bool result = false;
            
            uint figuresCode1 = _firstPlayerFigures.UnitsIntegralCode;
            uint figuresCode2 = _secondPlayerFigures.UnitsIntegralCode;
            List<uint> startCodeList = new List<uint>();

            if (IsFirstPlayerTurn)
            {
                startCodeList = ToSingleCodeList(figuresCode1);
            }
            else
            {
                startCodeList = ToSingleCodeList(figuresCode2);
            }
            
            var pairStartList = new List<uint>(); // Вынести в поля класса для ускорения ???
            var singleDestinationList = new List<uint>();
            var pairDestinationList = new List<uint>();
            startCellValue = 0;
            destinationCellValue = 0;
            int index = -1;

            foreach (var boardCellValue in startCodeList)
            {
                // Получение взаимосвязей для конкретной фигуры
                // Убрать Try ???
                _maskConverter.TryGetCellRelationCaseByValue(boardCellValue, out CellRelationCase cellRelationCase);

                // Получение всех возможных ходов фигуры 
                uint destinationCode = GetRandomMoveDestinationCode(boardCellValue); // для 1-го игрока
                singleDestinationList = ToSingleCodeList(destinationCode);

                foreach (var singleDestination in singleDestinationList)
                {
                    if ((singleDestination & figuresCode1) == 0
                        && (singleDestination & figuresCode2) == 0)
                    {
                        pairStartList.Add(boardCellValue);
                        pairDestinationList.Add(singleDestination);
                    }
                }
            }

            if (pairStartList.Count != 0)
            {
                index = rnd.Next(0, pairStartList.Count);
                startCellValue = pairStartList[index];
                destinationCellValue = pairDestinationList[index];
                result = true;
            }

            return result;
        }

        #endregion

    }
}
