using System;
using System.Linq;

namespace p12CountOccurrencesOfLargerNumbersInArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double searchNum = double.Parse(Console.ReadLine());

            int count = CountOccurrencesOfLargerNumInArray(arr, searchNum); 

            Console.WriteLine(count);
        }

        static int CountOccurrencesOfLargerNumInArray(double[] arr, double searchNum)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > searchNum)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
