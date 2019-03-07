using System;
using System.Collections.Generic;
using System.Linq;

class EqualSumAfterExtraction1
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

        foreach (var num in firstList)
        {           
            secondList.Remove(num);
        }

        int sumFirstLine = firstList.Sum();
        int sumSecondLine = secondList.Sum();
        int differentSum = Math.Abs(sumFirstLine - sumSecondLine);

        string result = sumFirstLine == sumSecondLine ?
            $"Yes. Sum: {sumFirstLine}" :
            $"No. Diff: {differentSum}";

        Console.WriteLine(result);
    }
}

