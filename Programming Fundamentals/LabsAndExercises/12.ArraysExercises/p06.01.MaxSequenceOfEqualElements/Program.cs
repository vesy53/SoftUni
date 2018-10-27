using System;
using System.Linq;

namespace p06MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int currentStart = 0;
            int currentLen = 1;
            int bestStart = 0;
            int bestLen = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLen++;

                    if (currentLen > bestLen)
                    {
                        bestStart = currentStart;
                        bestLen = currentLen;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLen = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
