using System;
using System.Linq;

namespace p07MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int length = 1;
            int start = 0;
            int bestLength = 0;
            int bestStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i-1])
                {
                    length++;

                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    length = 1;
                    start = i;
                }
            }
            /* first method for print
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
            Console.WriteLine(); */
            
            //second method for print
            Console.WriteLine(string.Join(" ", (arr
                .Select(x => x.ToString())
                .ToArray()), bestStart, bestLength));
        }
    }
}
