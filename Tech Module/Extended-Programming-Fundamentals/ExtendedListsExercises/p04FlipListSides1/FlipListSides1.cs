using System;
using System.Collections.Generic;
using System.Linq;

class FlipListSides1
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        for (int i = 1; i < numbers.Count / 2; i++)
        {
            int firstNum = numbers[i];
            int lastNum = numbers[numbers.Count - 1 - i];

            numbers[i] = lastNum;
            numbers[numbers.Count - 1 - i] = firstNum;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

