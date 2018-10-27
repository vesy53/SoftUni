using System;
using System.Linq;

namespace p03FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = arr.Length / 4;
            int[] firstArr = new int[k];
            int[] middleArr = new int[2 * k];
            int[] lastArr = new int[k];

            for (int i = 0; i < k; i++)
            {
                firstArr[i] = arr[i];              
                lastArr[i] = arr[arr.Length - 1 - i]; // take rotated last elements
            }

            for (int i = 0; i < 2 * k; i++)
            {
                middleArr[i] = arr[k + i];
            }

            Array.Reverse(firstArr);
            int[] sumArr = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                sumArr[i] = firstArr[i] + middleArr[i];
                sumArr[i + k] = lastArr[i] + middleArr[i + k];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
