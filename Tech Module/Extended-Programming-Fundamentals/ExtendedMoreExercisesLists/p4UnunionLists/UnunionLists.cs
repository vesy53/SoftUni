using System;
using System.Collections.Generic;
using System.Linq;

class UnunionLists
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

        numbers.Sort();
        
        Console.WriteLine(string.Join(" ", numbers));
    }
}

