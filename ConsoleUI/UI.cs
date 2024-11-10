using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModelLibrary;
using BLGameLib;
using ModelLibrary.Masks;
using System.Reflection;
using System.Xml.Linq;

namespace ConsoleUILib
{
    public class UI
    {
        #region Constants

        private const int NUMBER_OF_CELLS = 32;

        private const int BOARD_WIDTH = 8;
        private const int BOARD_HEIGHT = 8;

        private const char CHECKER = 'c';
        private const char KING = 'K';

        private const int START_X = 3;
        private const int SPACING_X = 6;
        private const int START_Y = 30;
        private const int SPACING_Y = 4;

        private const ConsoleColor FIRST_COLOR = ConsoleColor.Red;
        private const ConsoleColor SECOND_COLOR = ConsoleColor.Cyan;

        private const int MENU_START_COLOMN = 58;
        private const int MENU_START_ROW = 2;

        #endregion

        //private ConsoleController _controller;
        private UICellConvertor _convertor;

        #region ctor

        public UI()
        {
            //_controller = new ConsoleController();
            _convertor = new UICellConvertor();
        }

        //public UI(ConsoleController controller)
        //{
        //    _controller = controller;
        //}

        #endregion

        public void PlotEmptyBoard()
        {
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = BOARD_HEIGHT; i > 0; i--)
            {
                PlotLineOfEmptyBoard(i);
            }
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine("   a     b     c     d     e     f     g     h");
        }

        public void PlotLineOfEmptyBoard(int yCoordinate)
        {
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine("|     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|     |     |     |     |     |     |     |     | {yCoordinate}");
            Console.WriteLine("|     |     |     |     |     |     |     |     |");

        }

        public void PlotGame(Game currentGame)
        {
            //ConsoleController controller = new ConsoleController();
            PlotFigures(currentGame, 1, FIRST_COLOR);
            PlotFigures(currentGame, 2, SECOND_COLOR);
        }

        private void PlotFigures(Game currentGame, int sideOfFigures, ConsoleColor color)
        {
            int countOfFigures = currentGame.GetCountOfFigures(sideOfFigures);

            for (int f = 0; f < countOfFigures; f++)
            {
                BoardCellMask mask = currentGame.GetBoardCellMaskByIndex(sideOfFigures, f);
                _convertor.GetCoordinatesByMask(mask, out int vertical, out int horizontal);

                Console.ForegroundColor = color;

                Console.SetCursorPosition(START_X + SPACING_X * horizontal,
                    START_Y - SPACING_Y * (BOARD_HEIGHT - 1 - vertical));

                if (currentGame.IsKingOfFigures(f, sideOfFigures))
                {
                    Console.Write($"{KING}");
                }
                else
                {
                    Console.Write($"{CHECKER}");
                }

            }
        }

        private void PlotUnitByName(string name) // TODO: Add Kings
        {
            _convertor.GetCoordinatesByName(name, out int vertical, out int horizontal);
            Console.SetCursorPosition(START_X + SPACING_X * horizontal,
                START_Y - SPACING_Y * (BOARD_HEIGHT - 1 - vertical));

            Console.Write($"{CHECKER}");
        }

        private void EraseUnitByName(string name)
        {
            _convertor.GetCoordinatesByName(name, out int vertical, out int horizontal);
            Console.SetCursorPosition(START_X + SPACING_X * horizontal,
                START_Y - SPACING_Y * (BOARD_HEIGHT - 1 - vertical));

            Console.Write(" ");
        }

        private void PlotUnitByIndex(int index) // TODO: Add Kings
        {
            int vertical = _convertor.GetVerticalByIndex(index);
            int horizontal = _convertor.GetHorizontalByIndex(index);

            Console.SetCursorPosition(START_X + SPACING_X * horizontal,
                START_Y - SPACING_Y * (BOARD_HEIGHT - 1 - vertical));

            Console.Write($"{CHECKER}");
        }

        private void EraseUnitByIndex(int index)
        {
            int vertical = _convertor.GetVerticalByIndex(index);
            int horizontal = _convertor.GetHorizontalByIndex(index);

            Console.SetCursorPosition(START_X + SPACING_X * horizontal,
                START_Y - SPACING_Y * (BOARD_HEIGHT - 1 - vertical));

            Console.Write(" ");
        }


        public void PrintMenu(/*typeOfGame*/)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(MENU_START_COLOMN, MENU_START_ROW);
            Console.WriteLine("Choose an option:");

            Console.SetCursorPosition(MENU_START_COLOMN, MENU_START_ROW + 1);
            Console.WriteLine("M - Move a figure");

            Console.SetCursorPosition(MENU_START_COLOMN, MENU_START_ROW + 2);
            Console.WriteLine("D - offer a Draw");

            Console.SetCursorPosition(MENU_START_COLOMN, MENU_START_ROW + 3);
            Console.WriteLine("C - Capitulate");

            Console.SetCursorPosition(MENU_START_COLOMN, MENU_START_ROW + 4);
            Console.WriteLine("P - ask for return to the Previous move");
        }

        public void MoveFigure(Game currentGame/*, typeOfGame,*/ /*ref ConsoleKey key*/)
        {
            if (currentGame.IsFirstPlayerTurn)
            {
                Console.ForegroundColor = FIRST_COLOR;
            }
            else
            {
                Console.ForegroundColor = SECOND_COLOR;
            }

            InputMoveData(out string startCellName, out string destinationCellName);
            ClearMoveMenuLines();

            while (!currentGame.TryMoveFigureByCellName(startCellName, destinationCellName))
            {
                Console.SetCursorPosition(MENU_START_COLOMN, MENU_START_ROW + 6);
                Console.WriteLine("You are inputed wrong data. Try again");
                Console.ReadKey();
                ClearMoveMenuLines();

                InputMoveData(out startCellName, out destinationCellName);
                ClearMoveMenuLines();
            }

            EraseUnitByName(startCellName);
            PlotUnitByName(destinationCellName);
        }

        public void RandomMoveFigure(Game currentGame/*, typeOfGame,*/ /*ref ConsoleKey key*/)
        {
            if (currentGame.IsFirstPlayerTurn)
            {
                Console.ForegroundColor = FIRST_COLOR;
            }
            else
            {
                Console.ForegroundColor = SECOND_COLOR;
            }

            if (currentGame.TryGetRandomMoveIndexes(out int startCellIndex, out int destinationCellIndex))
            {

                EraseUnitByIndex(startCellIndex);
                PlotUnitByIndex(destinationCellIndex);
            }
        }

        private void InputMoveData(out string startCellName, out string destinationCellName)
        {
            Console.SetCursorPosition(MENU_START_COLOMN, MENU_START_ROW + 6);
            Console.Write("Input start Cell Name: ");
            startCellName = Console.ReadLine();

            Console.SetCursorPosition(MENU_START_COLOMN, MENU_START_ROW + 7);
            Console.Write("Input destination Cell Name: ");
            destinationCellName = Console.ReadLine();
        }

        private void ClearMoveMenuLines()
        {
            Console.SetCursorPosition(MENU_START_COLOMN, MENU_START_ROW + 6);
            Console.Write("                                            ");
            Console.SetCursorPosition(MENU_START_COLOMN, MENU_START_ROW + 7);
            Console.Write("                                            ");
        }

    }
}
