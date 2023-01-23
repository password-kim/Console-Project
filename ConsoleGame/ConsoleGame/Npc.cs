using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    enum NpcType
    {
        None,
        RaceNpc,
        ShopNpc
    }

    internal class Npc
    {
        private int _x;
        private int _y;
        private NpcType _type;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public NpcType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public void SayToPlayer(NpcType npcType)
        {
            switch(npcType)
            {
                case NpcType.RaceNpc:
                    Console.SetCursorPosition(Constants.TOWN_DIALOG_MIN_X, Constants.TOWN_DIALOG_MIN_Y);
                    Console.Write("안녕하신가!! 경마장으로 갈텐가?");
                    Console.SetCursorPosition(Constants.TOWN_DIALOG_MIN_X, Constants.TOWN_DIALOG_MIN_Y + 1);
                    Console.Write("[1] 간다.");
                    Console.SetCursorPosition(Constants.TOWN_DIALOG_MIN_X, Constants.TOWN_DIALOG_MIN_Y + 2);
                    Console.Write("[2] 안간다.");
                    Console.SetCursorPosition(Constants.TOWN_DIALOG_MIN_X, Constants.TOWN_DIALOG_MIN_Y + 3);
                    Console.Write(">>");
                    break;
                case NpcType.ShopNpc:
                    Console.SetCursorPosition(Constants.SHOP_DIALOG_MIN_X, Constants.SHOP_DIALOG_MIN_Y);
                    Console.Write("안녕하신가!! 카드를 뽑아보시겠는가?");
                    Console.SetCursorPosition(Constants.SHOP_DIALOG_MIN_X, Constants.SHOP_DIALOG_MIN_Y + 1);
                    Console.Write("[1] 뽑는다.");
                    Console.SetCursorPosition(Constants.SHOP_DIALOG_MIN_X, Constants.SHOP_DIALOG_MIN_Y + 2);
                    Console.Write("[2] 다음에.");
                    Console.SetCursorPosition(Constants.SHOP_DIALOG_MIN_X, Constants.SHOP_DIALOG_MIN_Y + 3);
                    Console.Write(">>");
                    break;
                default:
                    GameManager.ExitWithError($"잘못된 NPC타입입니다. In SayToPlayer {npcType}");
                    return;
            }
        }
    }
}
