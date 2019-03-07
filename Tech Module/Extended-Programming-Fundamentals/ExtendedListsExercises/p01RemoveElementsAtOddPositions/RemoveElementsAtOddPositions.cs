using System;
using System.Collections.Generic;
using System.Linq;

class RemoveElementsAtOddPositions
{
    static void Main(string[] args)
    {
        List<string> text = Console.ReadLine()
            .Split()           
            .ToList();

        List<string> remainingElements = new List<string>();

        for (int i = 0; i < text.Count; i++)
        {
            int sum = i + 1;

            if (sum % 2 == 0)
            {
                remainingElements.Add(text[i]);
            }
        }

        Console.WriteLine(string.Join("", remainingElements));
    }
}

