namespace p02._02.SetsOfElements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class SetsOfElements
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int[] sizes = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSize = sizes[0];
            int secondSize = sizes[1];

            for (int i = 0; i < firstSize + secondSize; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < firstSize)
                {
                    firstSet.Add(num);
                }
                else
                {
                    secondSet.Add(num);
                }
            }

            HashSet<int> result = new HashSet<int>();

            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}