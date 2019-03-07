using System;
using System.Collections.Generic;
using System.Linq;

class UnunionLists1
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int tour = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < tour; i++)
        {
            List<int> digits = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int j = 0; j < digits.Count; j++)
            {
                int currentDigit = digits[j];

                for (int k = 0; k < numbers.Count; k++)
                {
                    int currentNum = numbers[k];

                    if (currentNum == currentDigit)
                    {
                        numbers.RemoveAt(k);
                        k--;
                        count++;
                    }
                } 

                if (count > 0)
                {
                    digits.Remove(currentDigit);
                    j--;
                    count = 0;
                }
            }

            numbers.AddRange(digits);
        }

        numbers.Sort();

        Console.WriteLine(string.Join(" ", numbers));
    }
}



