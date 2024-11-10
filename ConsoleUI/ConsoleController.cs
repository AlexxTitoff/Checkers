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
            //_currentGame = new Game();
        }

        public ConsoleController(Game game, ConsoleKey key)
        {
            _key = key;
            _currentGame = game;
        }

        public void ExecuteOperations(Game currentGame, UI consoleView)
        {
            do
            {
                //consoleView.PrintMenu(/*typeOfGame);

                _key = Console.ReadKey(true).Key;

                switch (_key)
                {
                    case ConsoleKey.M:
                        consoleView.MoveFigure(currentGame/*, typeOfGame,*/ /*ref key*/);
                        break;
                    case ConsoleKey.R:
                        consoleView.RandomMoveFigure(currentGame/*, typeOfGame,*/ /*ref key*/);
                        break;
                    //case ConsoleKey.D:
                    //    OfferDraw(currentGame, /*typeOfGame, */ref key);
                    //    break;
                    //case ConsoleKey.U:
                    //    Capitulate(currentGame, /*typeOfGame, */ref key);
                    //    break;
                    //case ConsoleKey.D:
                    //    AskToCanselTheMove(currentGame, /*typeOfGame, */ref key);
                    //    break;
                    default:
                        break;
                }

            } while (_key != ConsoleKey.Escape);
        }






    }
}
