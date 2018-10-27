using System;
using System.Collections.Generic;
using System.Linq;

class ArrayData3
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
        string command = Console.ReadLine();

        double average = numbers.Average();

        numbers = numbers
            .Where(x => x >= average)
            .ToList();

        string result = string.Empty;

        if (command.Equals("Min"))
        {
            result = numbers.Min().ToString();
        }
        else if (command.Equals("Max"))
        {
            result = numbers.Max().ToString();
        }
        else if (command.Equals("All"))
        {
            result = string.Join(" ", numbers.OrderBy(n => n));
        }

        Console.WriteLine(result);
    }
}

