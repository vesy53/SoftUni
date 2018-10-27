using System;
using System.Collections.Generic;
using System.Linq;

class FlipListSides4
{
    static void Main(string[] args)
    {
        List<string> numbers = Console.ReadLine()
            .Split(' ')
            .ToList();

        for (int i = 1; i < numbers.Count / 2; i++)
        {
            string temp = numbers[i];
            numbers[i] = numbers[numbers.Count - 1 - i];
            numbers[numbers.Count - 1 - i] = temp;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

