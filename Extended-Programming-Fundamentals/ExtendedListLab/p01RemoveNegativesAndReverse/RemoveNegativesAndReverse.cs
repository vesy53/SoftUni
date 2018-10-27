using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> newList = new List<int>();
        bool isPositive = false;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 0)
            {
                newList.Add(numbers[i]);
                isPositive = true;
            }
        }

        newList.Reverse();

        if (isPositive)
        {
            Console.WriteLine(string.Join(" ", newList));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}

