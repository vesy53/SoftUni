using System;
using System.Linq;

namespace p04CountOccurrencesOfLargerNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double num = double.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > num)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
