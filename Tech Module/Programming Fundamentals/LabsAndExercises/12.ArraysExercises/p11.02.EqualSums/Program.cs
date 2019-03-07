using System;
using System.Linq;

namespace p11EqualSums1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool hasEqualSum = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = arr.Take(i).Sum();
                int rightSum = arr.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    hasEqualSum = true;
                    break;
                }
            }

            if (hasEqualSum == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
