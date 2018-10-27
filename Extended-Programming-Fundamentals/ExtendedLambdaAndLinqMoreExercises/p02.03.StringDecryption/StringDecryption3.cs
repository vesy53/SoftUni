using System;
using System.Collections.Generic;
using System.Linq;

class StringDecryption3
{
    static void Main(string[] args)
    {
        List<int> elements = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int skip = elements[0];
        int take = elements[1];

        numbers = numbers
            .Where(x => x >= 65 && x <= 90)
            .Skip(skip)
            .Take(take)
            .ToList();

        Console.WriteLine(string
            .Join("", numbers.Select(x => (char)x)));
    }
}

