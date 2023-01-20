namespace ConsoleGame
{
    internal class Program
    {
        static void Main()
        {
            Console.ResetColor();
            Console.Title = "The Horse";
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;

            Player player = new Player
            {
                X = 1,
                Y = 1,
                Icon = "K",
                Dir = Direction.None
            };
                

            while (true)
            {
                // ========= Render =============
                Console.Clear();
                Console.SetCursorPosition(player.X, player.Y);
                Console.Write(player.Icon);

                // ========= Input ==============
                ConsoleKey key = Console.ReadKey().Key;

                // ========= Update =============

                player.MovePlayer(key);

            }

        }
    }
}