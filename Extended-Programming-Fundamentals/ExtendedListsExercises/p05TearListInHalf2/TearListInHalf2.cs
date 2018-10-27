using System;
using System.Collections.Generic;
using System.Linq;

class TearListInHalf2
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> rightSide = numbers.Skip(numbers.Count / 2).ToList();

        for (int i = 0; i < rightSide.Count; i++)
        {
            int firstNum = rightSide[i] / 10;
            int lastNum = rightSide[i] % 10;
            int currentNumbers = numbers[i];

            Console.Write(firstNum + " " + currentNumbers + " " + lastNum + " ");
        }

        Console.WriteLine();
    }
}
