namespace p03._02.JediGalaxy
{
    using System;
    using System.Linq;

    public class JediGalaxy
    {
        public static void Main()
        {
            int[] dimestions = Console.ReadLine()
                .Split(new string[] { " " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimestions[0];
            int cols = dimestions[1];

            Board board = new Board(rows, cols);

            string command = Console.ReadLine();

            long sum = 0;

            while (command != "Let the Force be with you")
            {
                string ivoCoordinates = command;
                string evilCoordinates = Console.ReadLine();

                Evil evil = new Evil();
                evil.SetCoordinates(evilCoordinates);
                evil.DestroyedStars(board.Matrix);

                Player player = new Player();

                player.SetCoordinates(ivoCoordinates);
                sum += player.CalculateStars(board.Matrix);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
