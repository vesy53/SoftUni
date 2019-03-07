using System;
using System.Linq;

namespace p05CountOfOddNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int oddCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1 || arr[i] % 2 == -1)
                {
                    oddCount++;
                }
            }

            Console.WriteLine(oddCount);
        }
    }
}
