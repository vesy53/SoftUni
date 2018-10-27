using System;
using System.Linq;

namespace p13IncreasingSequenceOfElements1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool hasIncreasing = IncreasingSequenceOfElements(arr);         

            if (hasIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool IncreasingSequenceOfElements(int[] arr)
        {
            bool hasIncreasing = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    hasIncreasing = false;
                }
            }

            return hasIncreasing;
        }
    }
}
