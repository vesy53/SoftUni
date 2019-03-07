using System;
using System.Linq;

class BinarySearch1
{
    static void Main(string[] args)
    {
        int[] numsArr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int searchNum = int.Parse(Console.ReadLine());

        int linearCount = 0;
        int binaryCount = 0;

        linearCount = LinearSearchMethod(numsArr, searchNum, linearCount);
        PrintSortArray(numsArr);
        binaryCount =  BinarySearchMethod(numsArr, searchNum, binaryCount);

        if (numsArr.Contains(searchNum)) //if (numsArr.BinarySearch(searchNum) >= 0)
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

    static int BinarySearchMethod(int[] numsArr, int searchNum, int binaryCount)
    {
        int left = 0;
        int right = numsArr.Length - 1;

        while (left <= right)
        {
            binaryCount++;
            int middle = (left + right) / 2;

            if (numsArr[middle] == searchNum)
            {
                return binaryCount;
            }
            else if (numsArr[middle] < searchNum)
            {
                left = middle + 1;
            }
            else if (numsArr[middle] > searchNum)
            {
                right = middle - 1;
            }
        }

        return binaryCount;
    }

    static int LinearSearchMethod(int[] numsArr, int searchNum, int linearCount)
    {
        for (int i = 0; i < numsArr.Length; i++)
        {
            linearCount++;

            if (numsArr[i] == searchNum)
            {
                break;
            }
        }

        return linearCount;
    }

    static void PrintSortArray(int[] numsArr)
    {
        for (int i = 0; i < numsArr.Length; i++)
        {
            for (int j = i + 1; j < numsArr.Length; j++)
            {
                int firstNum = numsArr[i];
                int secondNum = numsArr[j];

                if (firstNum > secondNum)
                {
                    numsArr[i] = secondNum;
                    numsArr[j] = firstNum;
                }
            }
        }
    }
}

