using System;
using System.Collections.Generic;
using System.Linq;

class IncreasingCrisis3
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i < num - 1; i++)
        {
            List<int> currentNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int index = 0;

            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] <= currentNums[0])
                {
                    index++;
                }
                else
                {
                    break;
                }
            }

            for (int j = 0; j < numbers.Count; j++)
            {
                numbers.Insert((index + j), currentNums[0]);

                if (numbers[j] >= currentNums[0])
                {
                }
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

