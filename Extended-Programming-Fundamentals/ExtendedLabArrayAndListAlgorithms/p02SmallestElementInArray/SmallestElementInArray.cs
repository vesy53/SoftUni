using System;
using System.Linq;

class SmallestElementInArray
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int minNum = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minNum)
            {
                minNum = numbers[i];
            }
        }

        Console.WriteLine(minNum);
    }
}

