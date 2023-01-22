using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class RenderManager
    {
        public static void RenderObject(int x, int y, char icon)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(icon);
        }

        public static void RenderTitle()
        {
            Console.Clear();
            Console.SetCursorPosition(44, 10);
            Console.Write("     #####   #   #   #####    #   #    ###    ####     ####   #####    ");
            Console.SetCursorPosition(44, 11);
            Console.Write("       #     #   #   #        #   #   #   #   #   #   #       #        ");
            Console.SetCursorPosition(44, 12);
            Console.Write("       #     #####   ####     #####   #   #   ####    ####    ####     ");
            Console.SetCursorPosition(44, 13);
            Console.Write("       #     #   #   #        #   #   #   #   #   #       #   #        ");
            Console.SetCursorPosition(44, 14);
            Console.Write("       #     #   #   #####    #   #    ###    #   #   ####    #####    ");
            //Console.Write("\n\n");
            Console.SetCursorPosition(58, 18);
            Console.Write("     !!숫자를 누르고 엔터를 눌러주세요!!");
            Console.SetCursorPosition(65, 20);
            Console.Write("     [1] 게임시작.");
            Console.SetCursorPosition(65, 21);
            Console.Write("     [2] 게임종료.");
            Console.SetCursorPosition(65, 22);
            Console.Write("     >>");
        }

        public static void RenderGameExit()
        {
            Console.Clear();
            Console.SetCursorPosition(44, 10);
            Console.Write("    ####   #####   #####     #   #   ####    #    #   ##         ");
            Console.SetCursorPosition(44, 11);
            Console.Write("   #       #       #          # #   #    #   #    #   ##         ");
            Console.SetCursorPosition(44, 12);
            Console.Write("   #####   ####    ####        #    #    #   #    #   ##         ");
            Console.SetCursorPosition(44, 13);
            Console.Write("       #   #       #           #    #    #   #    #              ");
            Console.SetCursorPosition(44, 14);
            Console.Write("   ####    #####   #####       #     ####     ####    ##         ");
        }

        public static void ShowBackDialog()
        {
            Console.SetCursorPosition(50, 12);
            Console.Write("┌────────────────┐");
            Console.SetCursorPosition(50, 13);
            Console.Write("│");
            Console.SetCursorPosition(50, 14);
            Console.Write("└────────────────┘");

        }

        public static void ShowState(Player player)
        {
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y);
            Console.Write($"PlayerState : {player.PlayerState}");
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y + 1);
            Console.Write($"PlayerDirection : {player.Dir}");
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y + 2);
            Console.Write($"Player X : {player.X}");
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y + 3);
            Console.Write($"Player Y : {player.Y}");
        }
        
    }

    
}
