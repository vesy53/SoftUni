using System;
using System.Linq;

class SortArrayUsingBubbleSort3
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        BubbleSort(numbers);

        Console.WriteLine(string.Join(" ", numbers));
    }

    static int[] BubbleSort(int[] numbers)
    {
        bool isSorted = false;

        while (!isSorted)
        {
            bool isSwapped = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Swap(ref numbers[i], ref numbers[i + 1]);
                    isSwapped = true;
                }
            }

            if (isSwapped == false)
            {
                break;
            }
        }

        return numbers;
    }

    static void Swap(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }
}

