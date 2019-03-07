using System;
using System.Linq;

namespace p04CountOccurrencesOfLargerNumbersInArray1
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

            foreach (var a in arr)
            {
                if (a > num)
                {
                    count++;
                }
            }
            //another method
            // double count = arr.Where(a => a > num).Count();
            Console.WriteLine(count);
        }
    }
}
