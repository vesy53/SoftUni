using System;
using System.Collections.Generic;
using System.Linq;

class AppendList1
{
    static void Main(string[] args)
    {
        List<string> numbers = Console.ReadLine()
            .Split('|')
            .ToList();

        List<string> reversedNums = new List<string>();

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            List<string> currentElement = numbers[i]
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            reversedNums.AddRange(currentElement);
        }

        Console.WriteLine(string.Join(" ", reversedNums));
    }
}

