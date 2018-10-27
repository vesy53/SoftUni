using System;
using System.Collections.Generic;
using System.Linq;

namespace p01RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x > 0)
                .Reverse()
                .ToList();

            bool isEmpty = true;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != 0)
                {
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
