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
            Console.SetCursorPosition(15, 10);
            Console.Write("  :::::::::::       :::    :::       ::::::::::        :::    :::       ::::::::       :::::::::       ::::::::       :::::::::: ");
            Console.SetCursorPosition(15, 11);
            Console.Write("     :+:           :+:    :+:       :+:               :+:    :+:      :+:    :+:      :+:    :+:     :+:    :+:      :+:         ");
            Console.SetCursorPosition(15, 12);
            Console.Write("    +:+           +:+    +:+       +:+               +:+    +:+      +:+    +:+      +:+    +:+     +:+             +:+          ");
            Console.SetCursorPosition(15, 13);
            Console.Write("   +#+           +#++:++#++       +#++:++#          +#++:++#++      +#+    +:+      +#++:++#:      +#++:++#++      +#++:++#      ");
            Console.SetCursorPosition(15, 14);
            Console.Write("  +#+           +#+    +#+       +#+               +#+    +#+      +#+    +#+      +#+    +#+            +#+      +#+            ");
            Console.SetCursorPosition(15, 15);
            Console.Write(" #+#           #+#    #+#       #+#               #+#    #+#      #+#    #+#      #+#    #+#     #+#    #+#      #+#             ");
            Console.SetCursorPosition(15, 16);
            Console.Write("###           ###    ###       ##########        ###    ###       ########       ###    ###      ########       ##########       ");
            //Console.Write("\n\n");
            Console.SetCursorPosition(58, 20);
            Console.Write("     !!숫자를 누르고 엔터를 눌러주세요!!");
            Console.SetCursorPosition(65, 21);
            Console.Write("     [1] 게임시작.");
            Console.SetCursorPosition(65, 22);
            Console.Write("     [2] 게임종료.");
            Console.SetCursorPosition(65, 23);
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

        public static void ShowRank(Horse[] horses, int playerChoice)
        {
            bool[] isPrintLine = new bool[11];
            Console.SetCursorPosition(1, 14);
            Console.Write("Rank");

            for (int horseId = 0; horseId < Constants.HORSE_COUNT; ++horseId)
            {
                int l = horses[horseId].Rank - 1;
                while (true)
                {
                    if (isPrintLine[l])
                    {
                        l++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (horseId == playerChoice - 1)
                {
                    ConsoleColor prev = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(1, 15 + l);
                    Console.Write($"{horseId + 1,2}번마  {horses[horseId].Rank,2}등  {(horses[horseId].HorseSpeed * RandomManager.GetInctance.Next(10, 14)),3}km/h");
                    Console.ForegroundColor = prev;
                    isPrintLine[l] = true;
                }
                else
                {
                    Console.SetCursorPosition(1, 15 + l);
                    Console.Write($"{horseId + 1,2}번마  {horses[horseId].Rank,2}등  {(horses[horseId].HorseSpeed * RandomManager.GetInctance.Next(10, 14)),3}km/h");
                    isPrintLine[l] = true;
                }
            }
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
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y + 4);
            Console.Write($"Player Money : {Player.Money}");
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y + 5);
            Console.Write("<Card Collection>");
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y + 6);
            Console.Write($"Choi : {GameManager.Cards[0]}");
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y + 7);
            Console.Write($"Mino : {GameManager.Cards[1]}");
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y + 8);
            Console.Write($"HSJ  : {GameManager.Cards[2]}");
            Console.SetCursorPosition(Constants.TOWN_MAX_X + 3, Constants.TOWN_MIN_Y + 9);
            Console.Write($"Doik : {GameManager.Cards[3]}");

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

        public static void ShowGachaResult(Card card)
        {
            Console.SetCursorPosition(Constants.SHOP_GACHA_DIALOG_MIN_X, Constants.SHOP_GACHA_DIALOG_MIN_Y);
            Console.Write($"{card.Type}카드를 뽑으셨습니다!");
            Console.SetCursorPosition(Constants.SHOP_GACHA_DIALOG_MIN_X, Constants.SHOP_GACHA_DIALOG_MIN_Y + 1);
            Console.Write("계속하시려면 엔터를 눌러주세요.");
            Console.ReadLine();
        }

    }

    
}
