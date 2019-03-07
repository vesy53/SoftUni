using System;
using System.Collections.Generic;
using System.Linq;

class CamelsBack1
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
            Console.WriteLine("already stable: " + string.Join(" ",numbers));
            return;
        }

        int rounds = (numbers.Count - camelBackSize) / 2;
        var result = numbers.Skip(rounds).Take(camelBackSize);

        Console.WriteLine(
            $"{rounds} rounds\r\nremaining: " + string.Join(" ", result));
    }
}

