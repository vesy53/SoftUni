using System;
using System.Collections.Generic;
using System.Linq;

class EqualSumAfterExtraction2
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

        int sumFirstList = firstList.Sum();
        int sumOfEqualsElements = secondList.Sum() - secondList.Where(x => firstList.Contains(x)).Sum();
        int differentSum = Math.Abs(sumFirstList - sumOfEqualsElements);

        string result = sumOfEqualsElements == sumFirstList ?
            $"Yes. Sum: {sumFirstList}" :
            $"No. Diff: {differentSum}";

        Console.WriteLine(result);
    }
}

