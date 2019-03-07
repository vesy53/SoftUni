using System;
using System.Collections.Generic;
using System.Linq;

class CountNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .OrderBy(x => x)
            .ToList();

        int count = 1;

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine($"{numbers[i]} -> {count}");
                count = 1;
            }

            if (numbers[i] == numbers[numbers.Count - 1] 
                && numbers[i] != numbers[i - 1])
            {
                Console.WriteLine($"{numbers[i]} -> {count}");
            }
        }
    }
}

