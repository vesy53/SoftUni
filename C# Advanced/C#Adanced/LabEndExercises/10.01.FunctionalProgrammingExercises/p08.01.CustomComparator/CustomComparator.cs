namespace p08._01.CustomComparator
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

            Predicate<int> evenNum = e => e % 2 == 0;

            Func<List<int>, List<int>> takeEvenNumbers = nums =>
                 nums
                    .Where(n => evenNum(n) == true)
                    .OrderBy(n => n)
                    .ToList();

            Func<List<int>, List<int>> takeOddNumbers = nums =>
                 nums
                    .Where(n => evenNum(n) == false)
                    .OrderBy(n => n)
                    .ToList();

            Action<List<int>> print = p =>
                Console.Write(string.Join(" ", p));
            Action<char> printSpase = p => Console.Write(" ");
            Action<string> printCWL = p => Console.WriteLine();


            print(takeEvenNumbers(numbers));
            printSpase(' ');
            print(takeOddNumbers(numbers));
            printCWL("");
        }
    }
}
