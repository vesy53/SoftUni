using System;
using System.Linq;

class BinarySearch
{
    static bool isFound;

    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int searchNum = int.Parse(Console.ReadLine());

        int linearCount = 0;
        int binaryCount = 0;
        isFound = false;

        linearCount = LinearSearchMethod(numbers, searchNum, linearCount);
        SortArray(numbers);
        binaryCount = IntArrayBinarySearch(numbers, searchNum, binaryCount);

        if (isFound)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        Console.WriteLine($"Linear search made {linearCount} iterations");
        Console.WriteLine($"Binary search made {binaryCount} iterations");
    }

    static void SortArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
    }

    static int IntArrayBinarySearch(int[] numbers, int searchNum, int binaryCount)
    {
        int left = 0;
        int right = numbers.Length - 1;

        do
        {
            int middle = (left + right) / 2;
            binaryCount++;

            if (numbers[middle] > searchNum)
            {
                right = middle - 1;
            }
            else if (numbers[middle] < searchNum)
            {
                left = middle + 1;
            }

            if (numbers[middle] == searchNum)
            {
                return binaryCount;
            }
        } while (left <= right);

        return binaryCount;
    }

    static int LinearSearchMethod(int[] numbers, int searchNum, int linearCount)
    {
        isFound = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            linearCount++;

            if (numbers[i] == searchNum)
            {
                isFound = true;
                break;
            }
        }

        return linearCount;
    }
}

