using System;
using System.Linq;

class SmallestElementInArray1
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int minNum = int.MaxValue;

        foreach (var num in numbers)
        {
            if (num < minNum)
            {
                minNum = num;
            }
        }

        Console.WriteLine(minNum);
    }
}

