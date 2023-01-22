using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Npc
    {
        private int _x;
        private int _y;

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

        public void SayToPlayer()
        {
            Console.SetCursorPosition(Constants.DIALOG_MIN_X, Constants.DIALOG_MIN_Y);
            Console.Write("안녕하신가!! 경마장으로 갈텐가?");
            Console.SetCursorPosition(Constants.DIALOG_MIN_X, Constants.DIALOG_MIN_Y + 1);
            Console.Write("[1] 간다.");
            Console.SetCursorPosition(Constants.DIALOG_MIN_X, Constants.DIALOG_MIN_Y + 2);
            Console.Write("[2] 안간다.");
        }
    }
}
