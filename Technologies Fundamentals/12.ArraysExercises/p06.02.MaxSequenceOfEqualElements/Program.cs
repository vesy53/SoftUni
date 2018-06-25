using System;
using System.Linq;

namespace p06MaxSequenceOfEqualElements1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int length = 0;
            int endIndex = 0;
            int maxLength = -1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    length++;

                    if (length > maxLength)
                    {
                        maxLength = length;
                        endIndex = i + 1;
                    }
                }
                else
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                        endIndex = i + 1;
                    }

                    length = 0;
                }
            }

            PrintMaxSequenceOfEqualElements(arr, maxLength, endIndex);
        }

        static void PrintMaxSequenceOfEqualElements(int[] arr, int maxLength, int endIndex)
        {
            for (int i = 0; i <= maxLength; i++)
            {
                Console.Write(arr[endIndex] + " ");
            }

            Console.WriteLine();
        }
    }
}
