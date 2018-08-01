﻿using System;
using System.Collections.Generic;
using System.Linq;

class OddFilter3
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                numbers.RemoveAt(i);
                i--;
            }
        }

        double average = numbers.Average();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] <= average)
            {
                numbers[i]--;
            }
            else
            {
                numbers[i]++;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

