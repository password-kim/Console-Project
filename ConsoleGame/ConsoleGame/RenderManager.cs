using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class RenderManager
    {
        public void RenderObject(int x, int y, char icon)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(icon);
        }

        public void RenderTitle()
        {
            Console.Clear();
            Console.SetCursorPosition(44, 10);
            Console.WriteLine("     #####   #   #   #####    #   #    ###    ####     ####   #####    ");
            Console.SetCursorPosition(44, 11);
            Console.WriteLine("       #     #   #   #        #   #   #   #   #   #   #       #        ");
            Console.SetCursorPosition(44, 12);
            Console.WriteLine("       #     #####   ####     #####   #   #   ####    ####    ####     ");
            Console.SetCursorPosition(44, 13);
            Console.WriteLine("       #     #   #   #        #   #   #   #   #   #       #   #        ");
            Console.SetCursorPosition(44, 14);
            Console.WriteLine("       #     #   #   #####    #   #    ###    #   #   ####    #####    ");
            //Console.WriteLine("\n\n");
            Console.SetCursorPosition(58, 18);
            Console.WriteLine("     !!숫자를 누르고 엔터를 눌러주세요!!");
            Console.SetCursorPosition(65, 20);
            Console.WriteLine("     [1] 게임시작.");
            Console.SetCursorPosition(65, 21);
            Console.WriteLine("     [2] 게임종료.");
            Console.SetCursorPosition(65, 22);
            Console.Write("     >>");
        }

        public void RenderGameExit()
        {
            Console.Clear();
            Console.SetCursorPosition(44, 10);
            Console.WriteLine("    ####   #####   #####     #   #   ####    #    #   ##         ");
            Console.SetCursorPosition(44, 11);
            Console.WriteLine("   #       #       #          # #   #    #   #    #   ##         ");
            Console.SetCursorPosition(44, 12);
            Console.WriteLine("   #####   ####    ####        #    #    #   #    #   ##         ");
            Console.SetCursorPosition(44, 13);
            Console.WriteLine("       #   #       #           #    #    #   #    #              ");
            Console.SetCursorPosition(44, 14);
            Console.WriteLine("   ####    #####   #####       #     ####     ####    ##         ");
        }
    }

    
}
