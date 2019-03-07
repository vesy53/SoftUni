using System;
using System.Collections.Generic;
using System.Linq;

class ShortWordsSorted1
{
    static void Main(string[] args)
    {
        List<string> text = Console.ReadLine()
            .ToLower()
            .Split(".,:;()[]\"'\\/!? "
                .ToCharArray()
                , StringSplitOptions
                .RemoveEmptyEntries)
            .Distinct()
            .Where(t => t.Length < 5)
            .OrderBy(t => t)
            .ToList();

        Console.WriteLine(string.Join(", ", text));
    }
}

