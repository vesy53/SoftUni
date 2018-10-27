using System;
using System.Linq;

class SortArrayUsingBubbleSort
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int nextIndex = i + 1;

            while (nextIndex > 0)
            {
                if (numbers[nextIndex - 1] > numbers[nextIndex])
                {
                    int temp = numbers[nextIndex];
                    numbers[nextIndex] = numbers[nextIndex - 1];
                    numbers[nextIndex - 1] = temp;
                }

                nextIndex--;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

