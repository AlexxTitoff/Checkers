using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModelLibrary;
using BLGameLib;

namespace ConsoleUILib
{
    public class ConsoleController
    {
        private ConsoleKey _key;
        private UI _consoleView;
        private Game _currentGame;

        public ConsoleController(UI consoleView, Game currentGame)
        {
            _key = ConsoleKey.Spacebar;
            _consoleView = consoleView;
            _currentGame = currentGame;
        }

        public void ExecuteOperations()
        {
            _currentGame.GetIndexLists(out List<int> indexList1, out List<int> indexList2);
            _consoleView.PlotGame(indexList1, indexList2);

            do
            {
                _key = Console.ReadKey(true).Key;

                switch (_key)
                {
                    case ConsoleKey.R:
                        if (_currentGame.TryGetRandomMoveIndexes(
                            out int startCellIndex, out int destinationCellIndex))
                        {
                            _consoleView.PlotMove(_currentGame.IsFirstPlayerTurn,
                                startCellIndex, destinationCellIndex);
                        }

                        break;
                    default:
                        break;
                }

            } while (_key != ConsoleKey.Escape);
        }
    }
}
