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
        private Game _currentGame;

        public ConsoleController()
        {
            _key = ConsoleKey.Spacebar;
        }

        public void ExecuteOperations(Game currentGame, UI consoleView)
        {
            do
            {
                _key = Console.ReadKey(true).Key;

                switch (_key)
                {
                    case ConsoleKey.R:
                        consoleView.RandomMoveFigure(currentGame);
                        break;
                    default:
                        break;
                }

            } while (_key != ConsoleKey.Escape);
        }
    }
}
