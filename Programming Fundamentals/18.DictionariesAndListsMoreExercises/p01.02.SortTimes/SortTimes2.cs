using System;
using System.Linq;
using System.Collections.Generic;

class SortTimes2
{
    static void Main(string[] args)
    {
        List<string> times = Console.ReadLine()
            .Split()
            .OrderBy(t => t)
            .ToList();

        Console.WriteLine(string.Join(", ", times));
    }
}

