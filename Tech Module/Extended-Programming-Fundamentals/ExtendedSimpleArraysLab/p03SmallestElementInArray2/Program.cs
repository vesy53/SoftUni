using System;
using System.Linq;

namespace p03SmallestElementInArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int minValue = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }

            Console.WriteLine(minValue);
        }
    }
}
