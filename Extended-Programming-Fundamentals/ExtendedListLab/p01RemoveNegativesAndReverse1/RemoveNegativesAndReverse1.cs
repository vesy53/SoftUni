using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse1
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(x => x > 0)
            .Reverse()
            .ToList();

        var result = numbers.Count == 0 ?
            "empty" :
            string.Join(" ", numbers);

        Console.WriteLine(result);
    }
}

