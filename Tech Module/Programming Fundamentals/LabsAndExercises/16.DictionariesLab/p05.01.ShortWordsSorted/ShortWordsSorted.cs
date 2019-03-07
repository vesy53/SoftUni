using System;
using System.Collections.Generic;
using System.Linq;

class ShortWordsSorted
{
    static void Main(string[] args)
    {
        string[] text = Console.ReadLine()
            .Split(".,:;()[]\"'\\/!? "
            .ToCharArray()
            , StringSplitOptions
            .RemoveEmptyEntries)
            .Select(t => t.ToLower())
            .Distinct()
            .OrderBy(t => t)
            .ToArray();

        List<string> result = new List<string>();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Length < 5)
            {
                result.Add(text[i]);
            }
        }

        Console.WriteLine(string.Join(", ", result));
    }
}

