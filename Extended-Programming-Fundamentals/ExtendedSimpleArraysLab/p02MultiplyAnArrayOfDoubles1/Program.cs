using System;
using System.Linq;

namespace p02MultiplyAnArrayOfDoubles1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double numMultiply = double.Parse(Console.ReadLine());

            double[] sum = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                sum[i] = arr[i] * numMultiply;
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
