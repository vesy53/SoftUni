using System;
using System.Collections.Generic;
using System.Linq;

namespace p01MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int currentStartIndex = 0;
            int currentLength = 1;   
            
            int bestStartIndex = 0;
            int bestLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (currentNum == numbers[i - 1])
                {
                    currentLength++;

                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStartIndex = currentStartIndex;
                    }
                }
                else
                {
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStartIndex = currentStartIndex;
                    }

                    currentLength = 1;
                    currentStartIndex = i;
                }                         
            }

            for (int i = bestStartIndex; i < bestStartIndex + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            
            Console.WriteLine();

            // secomd method per print
            // Console.WriteLine(
            //     string.Join(" ", numbers
            //     .Skip(bestStartIndex)
            //     .Take(bestLength)));
        }
    }
}
