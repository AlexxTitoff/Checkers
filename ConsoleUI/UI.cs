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

        private UICellConvertor _convertor;
        //private Game _currentGame;

        #region ctor

        public UI(/*Game currentGame*/)
        {
            _convertor = new UICellConvertor();
            //_currentGame = currentGame;
        }

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

        public void PlotGame(List<int> indexList1, List<int> indexList2)
        {
            Console.ForegroundColor = FIRST_COLOR;

            foreach (var item in indexList1)
            {
                PlotUnitByIndex(item);
            }

            Console.ForegroundColor = SECOND_COLOR;

            foreach (var item in indexList2)
            {
                PlotUnitByIndex(item);
            }
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

        public void PrintMenu()
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

        public void PlotMove(bool isFirstPlayerTurn,
            int startCellIndex, int destinationCellIndex)
        {
            if (isFirstPlayerTurn)
            {
                Console.ForegroundColor = SECOND_COLOR; // TODO: очередность хода уже поменялась. Как с боем?
            }
            else
            {
                Console.ForegroundColor = FIRST_COLOR;
            }

            if (startCellIndex >= 0)
            {

                EraseUnitByIndex(startCellIndex);
                PlotUnitByIndex(destinationCellIndex);
            }
        }

    }
}
