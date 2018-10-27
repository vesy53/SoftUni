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

            int oddCount = CountOddNumbers(arr); 

            Console.WriteLine(oddCount);
        }

        static int CountOddNumbers(int[] arr)
        {
            int oddCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddCount++;
                }
            }

            return oddCount;
        }
    }
}
