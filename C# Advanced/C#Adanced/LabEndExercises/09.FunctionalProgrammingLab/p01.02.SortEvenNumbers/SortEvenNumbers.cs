namespace p01._02.SortEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(',',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList();

            Console.WriteLine(string.Join(", ", numbers));


            /*Console.WriteLine(
                string.Join(", ", Console.ReadLine()
                    .Split(',',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Where(n => n % 2 == 0)
                    .OrderBy(n => n)
                    .ToArray()));
            */
        }
    }
}