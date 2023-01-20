using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    enum Direction
    {
        None,
        Left,
        Right,
        Up,
        Down
    }

    internal class Player
    {
        private int _x;
        private int _y;
        private string _icon;
        private Direction _playerDirection;

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

        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
            }
        }

        public Direction Dir
        {
            get
            {
                return _playerDirection;
            }
            set
            {
                _playerDirection = value;
            }
        }

        public void MovePlayer(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                _x = Math.Clamp(_x - 1, Constants.MIN_X, Constants.MAX_X);
            }
            if (key == ConsoleKey.RightArrow)
            {
                _x = Math.Clamp(_x + 1, Constants.MIN_X, Constants.MAX_X);
            }
            if (key == ConsoleKey.UpArrow)
            {
                _y = Math.Clamp(_y - 1, Constants.MIN_Y, Constants.MAX_Y); 
            }
            if (key == ConsoleKey.DownArrow)
            {
                _y = Math.Clamp(_y + 1, Constants.MIN_Y, Constants.MAX_Y);
            }
        }

    }
}
