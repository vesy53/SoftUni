using System;
using System.Linq;

class StringDecryption2
{
    static void Main(string[] args)
    {
        int[] twoNums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int skip = twoNums[0];
        int take = twoNums[1];

        numbers = numbers
            .Where(x => x >= 65 && x <= 90)
            .Skip(skip)
            .Take(take)
            .ToArray();

        foreach (var num in numbers)
        {
            Console.Write((char)num);
        }

        Console.WriteLine();
    }
}

