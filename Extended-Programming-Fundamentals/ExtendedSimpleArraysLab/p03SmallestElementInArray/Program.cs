using System;
using System.Linq;

namespace p03SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(arr.Min());
        }
    }
}
