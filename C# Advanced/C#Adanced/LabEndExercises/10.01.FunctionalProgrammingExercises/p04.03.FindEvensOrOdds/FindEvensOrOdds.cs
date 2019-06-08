namespace p04._03.FindEvensOrOdds
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

            Predicate<int> predicate = TakeCondition(command);

            Queue<int> result = new Queue<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (predicate(i))
                {
                    result.Enqueue(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        static Predicate<int> TakeCondition(string command)
        {
            if (command == "odd")
            {
                return x => x % 2 != 0;
            }
            else
            {
                return x => x % 2 == 0;
            }
        }
    }
}