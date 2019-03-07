using System;
using System.Collections.Generic;
using System.Linq;

class AppendList
{
    static void Main(string[] args)
    {
        List<string> numbers = Console.ReadLine()
            .Split('|')
            .Reverse()
            .ToList();

        char[] delimeter = " ".ToCharArray();
        List<string> reversedNums = new List<string>();

        for (int i = 0; i < numbers.Count; i++)
        {
            List<string> currentElement = numbers[i]
                .Split(delimeter, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            reversedNums.AddRange(currentElement);
        } 

        Console.WriteLine(string.Join(" ", reversedNums));
    }
}

