﻿using System;
using System.Collections.Generic;
using System.Linq;

class OddFilter2
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> evenNums = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNums.Add(numbers[i]);
            }
        }

        double average = evenNums.Average();

        for (int i = 0; i < evenNums.Count; i++)
        {
            if (evenNums[i] <= average)
            {
                evenNums[i]--;
            }
            else
            {
                evenNums[i]++;
            }
        }

        Console.WriteLine(string.Join(" ", evenNums));
    }
}

