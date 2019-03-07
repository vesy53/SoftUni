using System;
using System.Collections.Generic;
using System.Linq;

class IncreasingCrisis
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        List<int> numsList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i < num - 1; i++)
        {
            List<int> currentNums = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            int searchIndex = 0;

            for (int j = 0; j < numsList.Count; j++)
            {
                if (numsList[j] <= currentNums[0])
                {
                    searchIndex++;
                }
                else
                {
                    break;
                }
            }

            for (int k = 0; k < currentNums.Count; k++)
            {
                numsList.Insert(searchIndex + k, currentNums[k]);

                if (searchIndex + k != numsList.Count - 1)
                {
                    if (currentNums[k] > numsList[searchIndex + k + 1])
                    {
                        break;
                    }
                }
            }

            searchIndex = 0;
            bool isBroken = false;

            for (int j = 1; j < numsList.Count; j++)
            {
                if (numsList[j - 1] > numsList[j])
                {
                    isBroken = true;
                    searchIndex = j;
                    break;
                }
            }

            if (isBroken)
            {
                numsList.RemoveRange(searchIndex, numsList.Count - searchIndex);
            }
        }
        Console.WriteLine(string.Join(" ", numsList));
    }
}

