using System;
using System.Collections.Generic;
using System.Linq;

class UnunionLists2
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int tour = int.Parse(Console.ReadLine());

        for (int i = 0; i < tour; i++)
        {
            List<int> digits = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            FindUniqueElements(numbers, tour, digits);
        }

        numbers.Sort();

        Console.WriteLine(string.Join(" ", numbers));
    }

    static void FindUniqueElements(List<int> numbers, int tour, List<int> digits)
    {
        for (int j = 0; j < digits.Count; j++)
        {
            int currentNum = digits[j];

            if (numbers.Contains(currentNum))
            {
                numbers.RemoveAll(x => x == currentNum);
            }
            else
            {
                numbers.Add(currentNum);
            }
        }
    }
}

