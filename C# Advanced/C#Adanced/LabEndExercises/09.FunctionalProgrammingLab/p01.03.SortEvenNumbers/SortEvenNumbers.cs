namespace p01._03.SortEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortEvenNumbers3
    {
        static List<int> numbers;

        static void Main(string[] args)
        {
            numbers = Console.ReadLine()
                .Split(',',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(n => n)
                .ToList();

            Func<int, bool> isEvens = n => n % 2 == 0;

            numbers = EvenNumbers(isEvens);

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static List<int> EvenNumbers(Func<int, bool> isEvens)
        {
            List<int> evenNums = new List<int>();

            foreach (int number in numbers)
            {
                if (isEvens(number))
                {
                    evenNums.Add(number);
                }
            }

            return evenNums;
        }
    }
}