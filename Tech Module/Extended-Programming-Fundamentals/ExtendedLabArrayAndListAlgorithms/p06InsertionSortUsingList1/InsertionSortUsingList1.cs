using System;
using System.Collections.Generic;
using System.Linq;

class InsertionSortUsingList1
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> sortedList = new List<int>();

        InsertionSortUsingList(numbers, sortedList);

        Console.WriteLine(string.Join(" ", sortedList));
    }

    static List<int> InsertionSortUsingList(List<int> numbers, List<int> sortedList)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            bool hasInserted = false;

            for (int j = 0; j < sortedList.Count; j++)
            {
                if (sortedList[j] > numbers[i])
                {
                    sortedList.Insert(j, numbers[i]);
                    hasInserted = true;
                    break;
                }
            }

            if (hasInserted == false)
            {
                sortedList.Add(numbers[i]);
            }
        }

        return sortedList;
    }
}

