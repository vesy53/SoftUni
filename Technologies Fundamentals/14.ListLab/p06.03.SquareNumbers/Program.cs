using System;
using System.Collections.Generic;
using System.Linq;

namespace p06SquareNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> squareNums = new List<int>();

            foreach (var num in numbers)
            {
                double currentNum = Math.Sqrt(num);

                if (currentNum == (int)currentNum)
                {
                    squareNums.Add(num);
                }
            }

            squareNums.Sort();
            squareNums.Reverse();

            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
