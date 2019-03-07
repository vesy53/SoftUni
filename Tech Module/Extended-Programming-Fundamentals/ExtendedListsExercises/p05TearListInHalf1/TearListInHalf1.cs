using System;
using System.Collections.Generic;
using System.Linq;

class TearListInHalf1
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> leftSide = numbers.Take(numbers.Count / 2).ToList();
        List<int> rightSide = numbers.Skip(numbers.Count / 2).ToList();

        int count = 0;
        int index = 0;

        while (true)
        {
            int firstNums = rightSide[count] / 10 % 10;
            int lastNums = rightSide[count] % 10;

            leftSide.Insert(index, firstNums);
            leftSide.Insert(index + 2, lastNums);

            count++;
            index += 3;

            if (count == rightSide.Count)
            {
                break;
            }
        }

        Console.WriteLine(string.Join(" ", leftSide));
    }
}

