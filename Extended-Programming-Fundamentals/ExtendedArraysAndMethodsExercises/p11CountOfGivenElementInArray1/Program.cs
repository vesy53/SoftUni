using System;
using System.Linq;

namespace p11CountOfGivenElementInArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int searchNum = int.Parse(Console.ReadLine());

            int count = CountOfGivenElementInArray(arr, searchNum);

            Console.WriteLine(count);
        }

        static int CountOfGivenElementInArray(int[] arr, int searchNum)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchNum)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
