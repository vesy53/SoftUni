using System;
using System.Collections.Generic;
using System.Linq;

class SumAdjacentEqualNumbers1
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        for (int i = 1; i < numbers.Count; i++)
        {
            int currentNum = numbers[i];
            int previousNum = numbers[i - 1];

            if (previousNum == currentNum)
            {
                currentNum = currentNum + previousNum;
                numbers.RemoveAt(i);
                numbers.RemoveAt(i - 1);
                numbers.Insert(i - 1, currentNum);
                i = 0;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

