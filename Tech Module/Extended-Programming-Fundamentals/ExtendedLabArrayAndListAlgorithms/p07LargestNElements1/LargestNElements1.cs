using System;
using System.Collections.Generic;
using System.Linq;

class LargestNElements1
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int searchLargestElement = int.Parse(Console.ReadLine());

        bool isInsertedSort = false;

        do
        {
            isInsertedSort = false;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int firstNum = numbers[i];
                int secondNum = numbers[i + 1];

                if (firstNum < secondNum)
                {
                    numbers[i] = secondNum;
                    numbers[i + 1] = firstNum;
                    isInsertedSort = true;
                }
            }

        } while (isInsertedSort);

        for (int i = 0; i < searchLargestElement; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
    }
}

