using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers1
{
    static void Main(string[] args)
    {
        SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
        double[] numbersInput = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        foreach (var num in numbersInput)
        {
            if (!numbers.ContainsKey(num))
            {
                numbers.Add(num, 0);
            }

            numbers[num]++;
        }

        foreach (KeyValuePair<double, int> num in numbers)
        {
            Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}

