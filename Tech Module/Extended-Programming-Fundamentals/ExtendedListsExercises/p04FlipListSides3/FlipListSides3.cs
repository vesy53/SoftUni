using System;
using System.Collections.Generic;
using System.Linq;

class FlipListSides3
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        LinkedList<int> reversedList = new LinkedList<int>();

        for (int i = numbers.Count - 2; i >= 1; i--)
        {
            reversedList.AddLast(numbers[i]);
        }

        reversedList.AddFirst(numbers.First());
        reversedList.AddLast(numbers.Last());

        Console.WriteLine(string.Join(" ", reversedList));
    }
}

