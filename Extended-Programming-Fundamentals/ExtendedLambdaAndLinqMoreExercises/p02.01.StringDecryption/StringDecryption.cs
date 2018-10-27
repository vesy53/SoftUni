using System;
using System.Linq;

class StringDecryption
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

        char[] letter = new char[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            letter[i] = Convert.ToChar(numbers[i]);
        }

        Console.WriteLine(string.Join("", letter));
    }
}

