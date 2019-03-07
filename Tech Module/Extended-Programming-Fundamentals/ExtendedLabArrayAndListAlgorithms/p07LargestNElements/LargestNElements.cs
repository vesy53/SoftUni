using System;
using System.Collections.Generic;
using System.Linq;

class LargestNElements
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int searchLargestElement = int.Parse(Console.ReadLine());

        int[] searchNum = new int[searchLargestElement];

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 0; j < numbers.Count - 1; j++)
            {
                if (numbers[j] < numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }                       
            }
        }

        for (int i = 0; i < searchLargestElement; i++)
        {
            Console.Write( numbers[i] + " ");
        }

        Console.WriteLine();
    }
}

