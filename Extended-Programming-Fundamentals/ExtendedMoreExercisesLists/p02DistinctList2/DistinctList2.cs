using System;
using System.Collections.Generic;
using System.Linq;

class DistinctList2
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 1 + i; j < numbers.Count; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    numbers.RemoveAt(j);
                    j--;
                }
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

