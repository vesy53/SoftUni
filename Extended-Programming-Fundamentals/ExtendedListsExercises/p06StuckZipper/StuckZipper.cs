using System;
using System.Collections.Generic;
using System.Linq;

class StuckZipper
{
    static void Main(string[] args)
    {
        List<int> firstList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        List<int> secondList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        //намираме мин. дължината на всеки един елемент
        int minLength = FindMinLengthNumber(firstList, secondList);

        List<int> firstFilteredList = new List<int>();
        List<int> secondFilteredList = new List<int>();
        //обхождаме елементите 1-н по 1-н и ако дължината им 
        //е <= на minLength ги добавяме в FilteredList
        for (int i = 0; i < firstList.Count; i++)
        {
            if (FindNumberLength(firstList[i]) <= minLength)
            {
                firstFilteredList.Add(firstList[i]);
            }
        }

        for (int i = 0; i < secondList.Count; i++)
        {
            if (FindNumberLength(secondList[i]) <= minLength)
            {
                secondFilteredList.Add(secondList[i]);
            }
        }

        List<int> result = new List<int>();
        var maxNum = Math.Max(firstFilteredList.Count, secondFilteredList.Count);

        for (int i = 0; i < maxNum; i++)
        {
            //I-во започваме от 2-ят List (по условие[0])
            if (i < secondFilteredList.Count)
            {
                result.Add(secondFilteredList[i]);
            }

            if (i < firstFilteredList.Count)
            {
                result.Add(firstFilteredList[i]);
            }
        }

        Console.WriteLine(string.Join(" ", result));      
    }

    static int FindMinLengthNumber(List<int> firstList, List<int> secondList)
    {
        int minLength = int.MaxValue;

        for (int i = 0; i < firstList.Count; i++)
        {
            if (minLength > FindNumberLength(firstList[i]))
            {
                minLength = FindNumberLength(firstList[i]);
            }
        }

        for (int i = 0; i < secondList.Count; i++)
        {
            if (minLength > FindNumberLength(secondList[i]))
            {
                minLength = FindNumberLength(secondList[i]);
            }
        }

        return minLength;
    }

    static int FindNumberLength(int number)
    {
        int digitCount = 0;
        number = Math.Abs(number);

        while (number > 0)
        {
            digitCount++;
            number /= 10;
        }

        return digitCount;
    }
}

