using System;
using System.Collections.Generic;
using System.Linq;

class CamelsBack2
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int camelBackSize = int.Parse(Console.ReadLine());


        if (camelBackSize == numbers.Count)
        {
            Console.WriteLine("already stable: " + string.Join(" ", numbers));
            return;
        }

        int rounds = (numbers.Count - camelBackSize) / 2;

        Console.Write($"{rounds} rounds\r\nremaining: ");

        for (int i = rounds; i < numbers.Count - rounds; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
    }
}

