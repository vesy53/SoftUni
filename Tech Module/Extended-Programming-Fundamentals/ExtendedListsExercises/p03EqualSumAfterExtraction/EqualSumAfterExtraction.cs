using System;
using System.Collections.Generic;
using System.Linq;

class EqualSumAfterExtraction
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

        for (int i = 0; i < firstList.Count; i++)
        {
            for (int j = 0; j < secondList.Count; j++)
            {
                if (firstList[i] == secondList[j])
                {
                    secondList.Remove(secondList[j]);
                }
            }
        }

        int sumFirstList = firstList.Sum();
        int sumSecondList = secondList.Sum();

        if (sumFirstList == sumSecondList)
        {
            Console.WriteLine($"Yes. Sum: {sumFirstList}");
        }
        else if (sumFirstList != sumSecondList)
        {
            int differentSum = Math.Abs(sumFirstList - sumSecondList);

            Console.WriteLine($"No. Diff: {differentSum}");
        }
    }
}

