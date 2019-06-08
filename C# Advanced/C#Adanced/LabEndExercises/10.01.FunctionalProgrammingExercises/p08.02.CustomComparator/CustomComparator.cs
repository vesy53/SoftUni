namespace p08._02.CustomComparator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CustomComparator
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, List<int>> funcEvenNums = nums =>
                    nums.Where(n => n % 2 == 0)
                        .ToList();
            Func<List<int>, List<int>> funcOddNums = nums =>
                    nums.Where(n => n % 2 != 0)
                        .ToList();

            Action<List<int>> print = p =>
                    Console.WriteLine(string.Join(" ", p));

            List<int> evenNums = funcEvenNums(numbers)
                        .OrderBy(n => n)
                        .ToList();
            List<int> oddNums = funcOddNums(numbers)
                        .OrderBy(n => n)
                        .ToList();

            evenNums.AddRange(oddNums);

            print(evenNums);
        }
    }
}
