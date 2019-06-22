namespace p01._03.CatapultAttack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CatapultAttack
    {
        static void Main(string[] args)
        {
            int trojans = int.Parse(Console.ReadLine());
            int[] inputSpartans = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> spartansWall = new Queue<int>(inputSpartans);
            Stack<int> trojansRock = new Stack<int>();

            for (int i = 1; i <= trojans; i++)
            {
                int[] inputTrojans = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                trojansRock = new Stack<int>(inputTrojans);

                if (i % 3 == 0)
                {
                    int newWall = int.Parse(Console.ReadLine());

                    Queue<int> newSpartansWall = new Queue<int>();

                    foreach (int spartanWall in spartansWall)
                    {
                        newSpartansWall.Enqueue(spartanWall);
                    }

                    newSpartansWall.Enqueue(newWall);

                    spartansWall = new Queue<int>(newSpartansWall);
                }

                while (spartansWall.Any() &&
                       trojansRock.Any())
                {
                    int wall = spartansWall.Dequeue();
                    int rock = trojansRock.Pop();

                    if (rock > wall)
                    {
                        trojansRock.Push(rock - wall);
                    }
                    else if (rock < wall)
                    {
                        Queue<int> newSpartansWall = new Queue<int>();

                        newSpartansWall.Enqueue(wall - rock);

                        foreach (int spartanWall in spartansWall)
                        {
                            newSpartansWall.Enqueue(spartanWall);
                        }

                        spartansWall = new Queue<int>(newSpartansWall);
                    }
                }

                if (!spartansWall.Any())
                {
                    break;
                }
            }

            if (spartansWall.Any())
            {
                Console.WriteLine(
                    $"Walls left: {string.Join(", ", spartansWall)}");
            }
            else if (trojansRock.Any())
            {
                Console.WriteLine(
                    $"Rocks left: {string.Join(", ", trojansRock)}");
            }
        }
    }
}
