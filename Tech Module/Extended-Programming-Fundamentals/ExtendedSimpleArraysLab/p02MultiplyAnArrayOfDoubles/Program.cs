using System;
using System.Linq;

namespace p02MultiplyAnArrayOfDoubles
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

            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i] * numMultiply;

                Console.Write(sum + " ");
            }

            Console.WriteLine();
        }
    }
}
