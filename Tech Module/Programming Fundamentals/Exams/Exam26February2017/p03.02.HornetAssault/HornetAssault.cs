using System;
using System.Collections.Generic;
using System.Linq;

namespace p03._02.HornetAssault
{
    class HornetAssault //90/100
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine()
                .Split(new char[] { ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                 .Select(long.Parse)
                 .ToList();
            List<long> hornets = Console.ReadLine()
                .Split(new char[] { ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            if (beehives.Count == 0)
            {
                Console.WriteLine(string.Join(" ", hornets));
                return;
            }

            if (hornets.Count == 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
                return;
            }

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Sum() > beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else
                {
                    beehives[i] -= hornets.Sum();

                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }
                    else
                    {
                        break;
                    }

                    if (beehives[i] <= 0)
                    {
                        beehives.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
