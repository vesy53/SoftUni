using System;
using System.Linq;

namespace p02RotateAndSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotationCount = int.Parse(Console.ReadLine());

            int[] sumArr = new int[arr.Length];

            for (int i = 0; i < rotationCount; i++)
            {
                RotatedArray(arr);

                for (int k = 0; k < arr.Length; k++)
                {
                    sumArr[k] += arr[k];
                }
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }

        static void RotatedArray(int[] arr)
        {
            int lastElement = arr[arr.Length - 1];

            for (int j = arr.Length - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];
            }

            arr[0] = lastElement;
        }
    }
}
