using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int counter = 0;
        List<int> newList = new List<int>();

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            if (numbers[i] > 0)
            {
                newList.Add(numbers[i]);
                counter++;
            }
        }

        var result = counter == 0 ?
            "empty" :
            string.Join(" ", newList);

        Console.WriteLine(result);
    }
}

