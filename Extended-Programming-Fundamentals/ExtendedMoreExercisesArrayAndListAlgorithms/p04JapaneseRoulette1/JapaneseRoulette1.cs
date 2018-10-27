using System;
using System.Collections.Generic;
using System.Linq;

namespace p04JapaneseRoulette1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<string> players = Console.ReadLine()
                .Split()
                .ToList();

            int bulletIndex = bullets.FindIndex(b => b == 1);
            int totalIndex = 0;

            for (int i = 0; i < players.Count; i++)
            {
                string[] currentPlayer = players[i].Split(',');
                int power = int.Parse(currentPlayer[0]);
                string directions = currentPlayer[1];

                switch (directions)
                {
                    case "Right":
                       totalIndex =  bulletIndex + power % bullets.Count;

                       if (totalIndex >= bullets.Count)
                       {
                           totalIndex -= bullets.Count;
                       }

                        break;

                    case "Left":
                        totalIndex = bulletIndex - power % bullets.Count;

                        if (totalIndex < 0)
                        {
                            totalIndex += bullets.Count;
                        }

                        break;
                }

                bulletIndex = totalIndex;

                if (bulletIndex == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    return;
                }

                bulletIndex++;
            }

            Console.WriteLine("Everybody got lucky!");
        }
    }
}
