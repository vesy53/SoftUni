using System;
using System.Collections.Generic;
using System.Linq;

namespace p06SquareNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> squareNums = numbers
                .Where(n => Math.Sqrt(n) == (int)Math.Sqrt(n))
                .OrderByDescending(n => n)
                .ToList();

            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
