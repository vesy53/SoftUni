using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse2
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Reverse()
            .ToList();

        int counter = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 0 )
            {
                Console.Write(numbers[i] + " ");
                counter++;
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("empty");
        }
    }
}

