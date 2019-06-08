namespace p04._02.FindEvensOrOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            int startNum = numbers[0];
            int endNum = numbers[1];

            Predicate<int> predicate;

            if (command == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else
            {
                predicate = n => n % 2 == 0;
            }

            List<int> result = EvensOrOdds(startNum, endNum, predicate);

            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> EvensOrOdds(
            int startNum,
            int endNum,
            Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}