using System;
using System.Collections.Generic;
using System.Linq;

class EqualSumAfterExtraction3
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

        for (int i = 0; i < secondList.Count; i++)
        {
            secondList.Where(x => !firstList.Contains(x)).ToList();
        }
        Console.WriteLine(string.Join(" ", secondList));
        Console.WriteLine();
        long sumSecondList = secondList.Sum();
        long sumFirstList = 0L;

        foreach (int number in firstList)
        {
            sumFirstList += number;
        }

        long differentSum = Math.Abs(sumFirstList - sumSecondList);

        if (sumSecondList == sumFirstList)
        {
            Console.WriteLine($"Yes. Sum: {sumFirstList}");
        }
        else
        {
            Console.WriteLine($"No. Diff: {differentSum}");

        }     
    }
}

