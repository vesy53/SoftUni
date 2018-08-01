using System;
using System.Collections.Generic;
using System.Linq;

class SortTimes
{
    static void Main(string[] args)
    {
        List<string> times = Console.ReadLine()
            .Split()
            .ToList();

        times.Sort();

        Console.WriteLine(string.Join(", ", times));
    }
}

