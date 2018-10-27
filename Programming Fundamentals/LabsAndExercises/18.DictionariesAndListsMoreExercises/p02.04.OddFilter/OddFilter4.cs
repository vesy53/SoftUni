using System;
using System.Collections.Generic;
using System.Linq;

class OddFilter4
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(n => n % 2 == 0)
            .ToList();

        double average = numbers.Average();

        numbers = numbers
            .Select(n => n > average ? ++n : --n)
            .ToList();

        Console.WriteLine(string.Join(" ", numbers));
    }
}

