using System;
using System.Collections.Generic;
using System.Linq;

class DistinctList1
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            int count = 0;

            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                }

                if (count > 1)
                {
                    numbers.RemoveAt(j);
                    j--;
                    count--;
                }
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

