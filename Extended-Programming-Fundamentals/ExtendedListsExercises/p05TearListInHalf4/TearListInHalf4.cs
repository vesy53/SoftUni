using System;
using System.Collections.Generic;
using System.Linq;

class TearListInHalf4
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] leftSide = numbers.Take(numbers.Length / 2).ToArray();
        int[] rightSide = numbers.Skip(numbers.Length / 2).ToArray();
        int length = numbers.Length + numbers.Length / 2;

        List<int> reversedNums = new List<int>(length);

        for (int i = 0; i < leftSide.Length; i++)
        {
            int firstNum = rightSide[i] / 10;
            int lastnum = rightSide[i] % 10;

            reversedNums.Add(firstNum);
            reversedNums.Add(leftSide[i]);
            reversedNums.Add(lastnum);
        }

        Console.WriteLine(string.Join(" ", reversedNums));
    }
}

