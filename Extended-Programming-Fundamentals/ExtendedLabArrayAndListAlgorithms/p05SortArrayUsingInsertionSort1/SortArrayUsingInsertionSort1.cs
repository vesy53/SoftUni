using System;
using System.Linq;

class SortArrayUsingInsertionSort1
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        InsertedSort(numbers);

        Console.WriteLine(string.Join(" ", numbers));
    }

    static int[] InsertedSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (numbers[j - 1] > numbers[j])
                {
                    Swap(ref numbers[j - 1], ref numbers[j]);                 
                }
            }
        }

        return numbers;
    }

    static void Swap(ref int firstNum, ref int secondNum)
    {
        int temp = firstNum;
        firstNum = secondNum;
        secondNum = temp;
    }
}

