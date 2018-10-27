using System;
using System.Linq;

class FoldAndSum
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

        var firstRow = leftSide
            .Concat(rightSide);

        int[] sum = firstRow
            .Select((x, index) => x + middleSide[index])
            .ToArray();

        Console.WriteLine(string.Join(" ", sum));
    }
}

