using System;
using System.Linq;
using System.Collections.Generic;

class CountRealNumbers
{
    static void Main(string[] args)
    {
        SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
        double[] numbersInput = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        for (int i = 0; i < numbersInput.Length; i++)
        {
            if (!numbers.ContainsKey(numbersInput[i]))
            {
                numbers.Add(numbersInput[i], 0);
            }

            numbers[numbersInput[i]]++;
        }

        foreach (KeyValuePair<double, int> num in numbers)
        {
            Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}

