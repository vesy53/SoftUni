using System;
using System.Collections.Generic;
using System.Linq;

class TakeSkipRope3
{
    static void Main(string[] args)
    {
        List<char> input = Console.ReadLine()
            .ToCharArray()
            .ToList();

        List<char> message = input
            .Where(x => !IsDigit(x))
            .ToList();

        List<int> numList = input
            .Where(x => IsDigit(x))
            .Select(x => int.Parse(x.ToString()))
            .ToList();

        List<int> takeList = numList
            .Where((x, i) => i % 2 == 0)
            .ToList();

        List<int> skipList = numList
            .Where((x, i) => i % 2 == 1)
            .ToList();

        string result = string.Empty;

        foreach (var item in takeList
            .Zip(skipList, Tuple.Create))
        {
            result += string
                .Join(null, message
                    .Select(x => x)
                    .Take(item.Item1));

            message = message
                .Skip(item.Item1 + item.Item2)
                .ToList();
        }

        Console.WriteLine(result);
    }

    static bool IsDigit(char symbol) 
        => '0' <= symbol && symbol <= '9';
    
}

