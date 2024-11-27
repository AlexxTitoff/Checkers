using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModelLibrary;
using ConsoleUILib;
using BLGameLib;
using ModelLibrary.Masks;


namespace MainApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConsoleController controller = new ConsoleController();
            UI consoleView = new UI();
            consoleView.PlotEmptyBoard();
            consoleView.PrintMenu();

            Game currentGame = new Game();
            consoleView.PlotGame(currentGame);

            controller.ExecuteOperations(currentGame, consoleView);

            // TODO: попробовать печать с Flags & без них
            //Console.WriteLine("{0}", BoardCellMask.a1);

            Console.ReadKey();
        }
    }
}
