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
            Console.Write("┌─────────────────────────────┐");
            Console.SetCursorPosition(50, 13);
            Console.Write("│마을로 돌아가시겠습니까?(y/n)│");
            Console.SetCursorPosition(50, 14);
            Console.Write("│>>                           │");
            // Console.SetCursorPosition(50, 15);
            // Console.Write("│");
            Console.SetCursorPosition(50, 15);
            Console.Write("└─────────────────────────────┘");

        }

        public static void ShowRank(int[] rank)
        {
            Console.SetCursorPosition(1, 14);
            Console.Write("Rank");
            for (int i = 0; i < Constants.HORSE_COUNT; ++i)
            {
                Console.SetCursorPosition(1, 15 + i);
                Console.Write($"{i + 1, 2}번마  {rank[i], 2}등");
            }
            //Console.SetCursorPosition(1, 15);
            //Console.Write($"1번마  {rank[0],2}등");
            //Console.SetCursorPosition(1, 16);
            //Console.Write($"2번마  {rank[1],2}등");
            //Console.SetCursorPosition(1, 17);
            //Console.Write($"3번마  {rank[2],2}등");
            //Console.SetCursorPosition(1, 18);
            //Console.Write($"4번마  {rank[3],2}등");
            //Console.SetCursorPosition(1, 19);
            //Console.Write($"5번마  {rank[4],2}등");
            //Console.SetCursorPosition(1, 20);
            //Console.Write($"6번마  {rank[5],2}등");
            //Console.SetCursorPosition(1, 21);
            //Console.Write($"7번마  {rank[6],2}등");
            //Console.SetCursorPosition(1, 22);
            //Console.Write($"8번마  {rank[7],2}등");
            //Console.SetCursorPosition(1, 23);
            //Console.Write($"9번마  {rank[8],2}등");
            //Console.SetCursorPosition(1, 24);
            //Console.Write($"10번마 {rank[9],2}등");
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
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y + 3);
            Console.Write($"Player Money : {Player.Money}");
        }

        public static void ShowRankTest(int[] rank)
        {
            Console.SetCursorPosition(21, 10);
            Console.Write($"{rank[0]}");
            Console.SetCursorPosition(21, 11);
            Console.Write($"{rank[1]}");
            Console.SetCursorPosition(21, 12);
            Console.Write($"{rank[2]}");
            Console.SetCursorPosition(21, 13);
            Console.Write($"{rank[3]}");
            Console.SetCursorPosition(21, 14);
            Console.Write($"{rank[4]}");
            Console.SetCursorPosition(21, 15);
            Console.Write($"{rank[5]}");
        }
    }

    
}
