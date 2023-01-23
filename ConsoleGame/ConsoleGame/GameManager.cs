using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class GameManager
    {
        private static int[] _cards = { 5, 0, 0, 0 };
        private static int _totalWeight = 100;

        private static Card[] _cardsTable = new Card[(int)CardType.MAX]
        {
            new Card {Type = CardType.Choi, Weight = 10},
            new Card {Type = CardType.Mino, Weight = 20},
            new Card {Type = CardType.HSJ, Weight = 30},
            new Card {Type = CardType.Doik, Weight = 40}
        };

        public static int TotalWeight
        {
            get
            {
                return _totalWeight;
            }
            set
            {
                _totalWeight = value;
            }
        }

        public static int[] Cards
        {
            get
            {
                return _cards;
            }
            set
            {
                _cards = value;
            }
        }

        public static Card[] CardsTable
        {
            get
            {
                return _cardsTable;
            }
            set
            {
                _cardsTable = value;
            }
        }

        public static void ExitWithError(string msg)
        {
            Console.Clear();
            Console.Write(msg);
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

        public static Card Gacha(Card[] cards)
        {
            Card card = null;
            int weight = 0;
            int selectedNumber = (int)(1 + RandomManager.GetInctance.NextDouble() * (GameManager.TotalWeight - 1) + 0.5);
            for (int i = 0; i < cards.Length; ++i)
            {
                weight += cards[i].Weight;
                if (selectedNumber <= weight)
                {
                    card = cards[i];
                    break;
                }
            }

            return card;
        }

        public static int ChoiceHorse(int playerChoice)
        {
            Console.SetCursorPosition(25, 14);
            Console.Write("몇번말에 거시겠습니까?");
            Console.SetCursorPosition(25, 15);
            Console.Write(">> ");
            Console.SetCursorPosition(28, 15);
            return playerChoice = int.Parse(Console.ReadLine());
        }

        public static void UseCard(ConsoleKey key)
        {
            // TODO
            // 카드사용 효과
        }
    }
}
