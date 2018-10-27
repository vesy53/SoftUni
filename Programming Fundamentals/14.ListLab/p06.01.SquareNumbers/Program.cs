using System;
using System.Collections.Generic;
using System.Linq;

namespace p06SquareNumbers
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

            List<int> squareNums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    squareNums.Add(numbers[i]);
                }
            }
         
            squareNums.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
