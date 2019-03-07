using System;
using System.Collections.Generic;
using System.Linq;

class TearListInHalf3
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        int index = 0;
        int remover = 0;

        for (int i = numbers.Count / 2; i < numbers.Count; i += 3)
        {
            for (int j = 0; j < 2; j++)
            {
                if (j == 0)
                {
                    numbers.Insert(index, numbers[i] / 10);
                    index += 2;
                }
                else
                {
                    numbers.Insert(index, numbers[i + 1] % 10);
                    index += 2;
                }
            }

            index -= 1;
            remover++;
        }

        numbers.RemoveRange(numbers.Count - remover, remover);

        Console.WriteLine(string.Join(" ", numbers));
    }
}

