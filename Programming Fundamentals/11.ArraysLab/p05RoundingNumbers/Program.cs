using System;
using System.Linq;

namespace p05RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double[] secArr = arr.ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                secArr[i] = Math.Round(arr[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{arr[i]} => {secArr[i]}");
            }
        }
    }
}
