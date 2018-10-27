using System;
using System.Collections.Generic;
using System.Linq;

class AppendList2
{
    static void Main(string[] args)
    {
        List<string> numbers = Console.ReadLine()
            .Split('|')
            .Reverse()
            .ToList();

        List<string> reversedElement = new List<string>();

        foreach (var num in numbers)
        {
            List<string> currentElement = num
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            reversedElement.AddRange(currentElement);
        }

        Console.WriteLine(string.Join(" ", reversedElement));
    }
}

