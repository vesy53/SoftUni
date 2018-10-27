using System;
using System.Collections.Generic;
using System.Linq;

namespace p01RemoveNegativesAndReverse3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int counter = 0;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > 0)
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
}
