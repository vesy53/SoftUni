using System;
using System.Linq;

namespace p12CountOccurrencesOfLargerNumbersInArray2
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

            var count = arr.Where(x => x > searchNum).Count();

            Console.WriteLine(count);
        }
    }
}
