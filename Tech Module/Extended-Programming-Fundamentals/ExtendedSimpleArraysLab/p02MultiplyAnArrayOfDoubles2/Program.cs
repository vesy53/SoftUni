using System;
using System.Linq;

namespace p02MultiplyAnArrayOfDoubles2
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

            foreach (var a in arr)
            {
                Console.Write(a * numMultiply + " ");
            }
            
            Console.WriteLine();
        }
    }
}
