using System;
using System.Collections.Generic;
using System.Linq;

namespace p01MaxSequenceOfEqualElements2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int bestLength = 0;
            int startIndex = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;

                    if (count > bestLength)
                    {
                        bestLength = count;
                        startIndex = i;
                    }
                }
                else
                {
                    if (count > bestLength)
                    {
                        bestLength = count;
                        startIndex = i;
                    }

                    count = 1;
                }
            }

            Console.WriteLine(string
                .Concat(Enumerable
                .Repeat($"{numbers[startIndex]} ", bestLength)));
        }
    }
}
