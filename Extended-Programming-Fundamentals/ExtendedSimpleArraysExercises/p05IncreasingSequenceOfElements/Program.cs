using System;
using System.Linq;

namespace p05IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool hasIncreasingSequence = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {              
                if(arr[i] >= arr[i + 1])
                {
                    hasIncreasingSequence = false;
                    break;
                }
            }

            if (hasIncreasingSequence)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
