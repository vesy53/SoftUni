namespace p01._01.CatapultAttack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CatapultAttack
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] spartanWalls = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> walls = new List<int>(spartanWalls);

            Stack<int> stackPiles = new Stack<int>();

            for (int i = 1; i <= number; i++)
            {
                int[] trojanPiles = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                stackPiles = new Stack<int>(trojanPiles);

                if (i % 3 == 0)
                {
                    int numberWall = int.Parse(Console.ReadLine());

                    walls.Add(numberWall);
                }

                while (walls.Count != 0 &&
                    stackPiles.Count != 0)
                {
                    int wall = walls[0];
                    int pile = stackPiles.Pop();

                    if (pile > wall)
                    {
                        walls.RemoveAt(0);
                        pile -= wall;
                        stackPiles.Push(pile);
                    }
                    else if (pile < wall)
                    {
                        wall -= pile;
                        walls[0] = wall;
                    }
                    else if (pile == wall)
                    {
                        walls.RemoveAt(0);
                    }
                }

                if (walls.Count == 0)
                {
                    break;
                }
            }

            if (walls.Count != 0)
            {
                Console.WriteLine(
                    $"Walls left: {string.Join(", ", walls)}");
            }
            else
            {
                Console.WriteLine(
                    $"Rocks left: {string.Join(", ", stackPiles)}");
            }
        }
    }
}
