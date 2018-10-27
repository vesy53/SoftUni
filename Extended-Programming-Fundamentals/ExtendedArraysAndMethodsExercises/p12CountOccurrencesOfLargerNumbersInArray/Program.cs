using System;
using System.Linq;

namespace p12CountOccurrencesOfLargerNumbersInArray
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

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > searchNum)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
