using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class GameManager
    {
        public static void ExitWithError(string msg)
        {
            Console.Clear();
            Console.WriteLine(msg);
            Environment.Exit(0);
        }

        public static void Initialize()
        {
            Console.ResetColor();
            Console.Title = "The Horse";
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
