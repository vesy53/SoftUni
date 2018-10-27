using System;
using System.Collections.Generic;
using System.Linq;

class SumMinMaxAverage
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = 0; i < num; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());

            numbers.Add(currentNum);
        }

        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Min = {numbers.Min()}");
        Console.WriteLine($"Max = {numbers.Max()}");
        Console.WriteLine($"Average = {numbers.Average()}");
    }
}

