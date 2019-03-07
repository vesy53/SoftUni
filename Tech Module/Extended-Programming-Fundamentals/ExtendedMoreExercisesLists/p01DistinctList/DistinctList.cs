using System;
using System.Collections.Generic;
using System.Linq;

class DistinctList
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .Distinct()
            .ToList();

        Console.WriteLine(string.Join(" ", numbers));
    }
}

