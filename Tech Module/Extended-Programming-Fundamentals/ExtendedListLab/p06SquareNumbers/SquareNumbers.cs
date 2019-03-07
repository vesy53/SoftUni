using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(new char[] { ' ' }
            , StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderByDescending(x => x)
            .ToList();

        List<int> squareNum = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            double sqrt = Math.Sqrt(numbers[i]);

            if (sqrt == (int)Math.Sqrt(numbers[i]))
            {
                squareNum.Add(numbers[i]);
            }
        }

        Console.WriteLine(string.Join(" ", squareNum));
    }
}

