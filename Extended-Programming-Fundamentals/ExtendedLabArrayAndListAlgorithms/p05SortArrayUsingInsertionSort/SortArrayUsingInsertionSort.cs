using System;
using System.Linq;

class SortArrayUsingInsertionSort
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (numbers[j - 1] > numbers[j])
                {
                    int temp = numbers[j - 1];
                    numbers[j - 1] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

