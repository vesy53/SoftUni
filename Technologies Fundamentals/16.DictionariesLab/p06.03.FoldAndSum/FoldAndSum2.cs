using System;
using System.Linq;

class FoldAndSum2
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int k = numbers.Length / 4;

        int[] leftSide = numbers
            .Take(k)
            .Reverse()
            .ToArray();
        int[] middleSide = numbers
            .Skip(k)
            .Take(2 * k)
            .ToArray();
        int[] rightSide = numbers
            .Skip(3 * k)
            .Take(k)
            .Reverse()
            .ToArray();

        int[] firstRow = leftSide
            .Concat(rightSide).ToArray();

        for (int i = 0; i < middleSide.Length; i++)
        {
            middleSide[i] += firstRow[i];
        }

        Console.WriteLine(string.Join(" ", middleSide));
    }
}

