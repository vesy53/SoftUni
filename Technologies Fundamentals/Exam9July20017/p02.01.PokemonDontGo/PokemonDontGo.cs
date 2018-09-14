namespace p02._01.PokemonDontGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            List<long> distance = Console.ReadLine()
                .Split(new char[] { ' ', '\t' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long sum = 0;
            long currentNum = 0;

            while (distance.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    long lastElement = distance[distance.Count - 1];
                    long firstElement = distance[0];
                    currentNum = firstElement;
                    distance.RemoveAt(0);
                    distance.Insert(0, lastElement);
                }
                else if (index > distance.Count - 1)
                {
                    long firstElement = distance[0];
                    distance.RemoveAt(distance.Count - 1);
                    distance.Insert(distance.Count, firstElement);
                    currentNum = firstElement;
                }
                else
                {
                    currentNum = distance[index];
                    distance.RemoveAt(index);
                }

                sum += currentNum;

                for (int i = 0; i < distance.Count; i++)
                {
                    if (distance[i] <= currentNum)
                    {
                        distance[i] += currentNum;
                    }
                    else if (distance[i] > currentNum)
                    {
                        distance[i] -= currentNum;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
