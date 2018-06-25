using System;
using System.Linq;

namespace p11EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
          
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;

                for (int l = 0; l < i; l++)
                {
                    leftSum += arr[l];
                }

                for (int r = i; r < arr.Length - 1; r++)
                {
                    rightSum += arr[r + 1];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            if (leftSum != rightSum)
            {
                Console.WriteLine("no");
            }
                     
        }
    }
}
