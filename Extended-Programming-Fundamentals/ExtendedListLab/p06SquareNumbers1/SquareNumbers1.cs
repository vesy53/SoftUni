using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers1
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

        foreach (var num in numbers)
        {
            if (Math.Sqrt(num) % 1 == 0)
            {
                squareNums.Add(num);
            }
        }

        squareNums.Sort();
        squareNums.Reverse();

        Console.WriteLine(string.Join(" ", squareNums));
    }
}

