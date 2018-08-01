using System;
using System.Collections.Generic;
using System.Linq;

class OddFilter
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> evenNums = numbers
            .Where(n => n % 2 == 0)
            .ToList();

        double average = evenNums.Average();

        for (int i = 0; i < evenNums.Count; i++)
        {
            if (evenNums[i] <= average)
            {
                evenNums[i]--;
            }
            else if(evenNums[i] > average)
            {
                evenNums[i]++;
            }
        }

        Console.WriteLine(string.Join(" ", evenNums));
    }
}

