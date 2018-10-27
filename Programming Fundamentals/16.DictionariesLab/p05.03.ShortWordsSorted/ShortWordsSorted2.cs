using System;
using System.Collections.Generic;
using System.Linq;

class ShortWordsSorted2
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine()
            .ToLower()
            .Split(".,:;()[]\"\\/!? "
                .ToCharArray()
                , StringSplitOptions
                .RemoveEmptyEntries)
            .OrderBy(x => x)
            .Distinct()
            .ToArray();

        var words = new List<string>();

        foreach (var symbol in text)
        {
            if (symbol.Length < 5)
            {
                words.Add(symbol);
            }
        }

        Console.WriteLine(string.Join(", ", words));
    }
}

