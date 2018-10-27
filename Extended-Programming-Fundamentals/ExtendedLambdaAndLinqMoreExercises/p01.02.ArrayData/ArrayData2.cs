using System;
using System.Linq;

class ArrayData2
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        string command = Console.ReadLine();

        double average = numbers.Average();

        numbers = numbers
            .Where(x => x >= average)
            .ToArray();

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

