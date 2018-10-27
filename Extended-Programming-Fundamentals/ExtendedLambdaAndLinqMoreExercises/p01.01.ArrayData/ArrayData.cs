using System;
using System.Linq;

class ArrayData
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

        if (command.Equals("Min"))
        {
            Console.WriteLine(numbers.Min());
        }
        else if (command.Equals("Max"))
        {
            Console.WriteLine(numbers.Max());
        }
        else if (command.Equals("All"))
        {
            numbers = numbers
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

