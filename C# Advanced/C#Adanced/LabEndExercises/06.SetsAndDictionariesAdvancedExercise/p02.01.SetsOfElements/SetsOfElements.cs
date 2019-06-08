namespace p02._01.SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

            AddNumbers(firstSet, firstSize);
            AddNumbers(secondSet, secondSize);

            IEnumerable<int> result = firstSet.Intersect(secondSet);

            Console.WriteLine(string.Join(" ", result));
        }

        static void AddNumbers(HashSet<int> hashSet, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int num = int.Parse(Console.ReadLine());

                hashSet.Add(num);
            }
        }
    }
}