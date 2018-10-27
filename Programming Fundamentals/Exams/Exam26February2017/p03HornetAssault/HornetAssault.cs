namespace p03.HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HornetAssault   //90/100
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

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                if (hornets.Sum() > beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else if (hornets.Sum() <= beehives[i])
                {
                    beehives[i] -= hornets.Sum();
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Where(x => x > 0).Count() > 0)
            {
                Console.WriteLine(
                    string.Join(" ", beehives.Where(x => x > 0)));
            }
            else 
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
