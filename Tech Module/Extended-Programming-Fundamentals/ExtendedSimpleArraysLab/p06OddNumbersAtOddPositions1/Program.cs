using System;
using System.Linq;

namespace p06OddNumbersAtOddPositions1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            SearchOddNumAtOddPositions(arr);
        }

        static void SearchOddNumAtOddPositions(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if ((arr[i] % 2 == 1 || arr[i] % 2 == -1)
                    && i % 2 == 1)
                {
                    Console.WriteLine($"Index {i} -> {arr[i]}");
                }
            }
        }
    }
}
