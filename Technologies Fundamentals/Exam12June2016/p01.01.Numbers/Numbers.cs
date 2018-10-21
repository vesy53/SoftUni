namespace p01._01.Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Numbers
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            double average = numbers.Average();

            numbers = numbers
                .Where(x => x > average)
                .OrderByDescending(x => x)
                .Take(5)
                .ToList();

            if (numbers.Count >= 1)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
