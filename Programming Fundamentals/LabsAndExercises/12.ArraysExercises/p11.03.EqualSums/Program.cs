using System;
using System.Linq;

namespace p11EqualSums2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int l = 0; l < i; l++)
                {
                    leftSum += arr[l];
                }

                for (int r = arr.Length - 1; r > i; r--)
                {
                    rightSum += arr[r];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
