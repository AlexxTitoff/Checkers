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
            UI consoleView = new UI();
            consoleView.PlotEmptyBoard();
            consoleView.PrintMenu();

            Game currentGame = new Game();

            ConsoleController controller = new ConsoleController(consoleView, currentGame);
            controller.ExecuteOperations();

            // TODO: попробовать печать с Flags & без них
            //Console.WriteLine("{0}", BoardCellMask.a1);

            Console.ReadKey();
        }
    }
}
