namespace p09._02.ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();

            Func<int, List<int>, bool> function = TakiTheDivisibleNums;

            for (int i = 1; i <= endNum; i++)
            {
                if (function(i, numbers))
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }

        static bool TakiTheDivisibleNums(int index, List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (index % number != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}