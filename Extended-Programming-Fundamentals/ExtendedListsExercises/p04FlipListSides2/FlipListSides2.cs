using System;
using System.Collections.Generic;
using System.Linq;

class FlipListSides2
{
    static void Main(string[] args)
    {
        List<string> numbers = Console.ReadLine()
            .Split()
            .ToList();

        List<string> reversedList = new List<string>();

        for (int i = numbers.Count - 2; i >= 1; i--)
        {
            reversedList.Add(numbers[i]);
        }

        reversedList.Insert(0, numbers[0]);
        reversedList.Add(numbers[numbers.Count - 1]);
        
        Console.WriteLine(string.Join(" ", reversedList));
    }
}

