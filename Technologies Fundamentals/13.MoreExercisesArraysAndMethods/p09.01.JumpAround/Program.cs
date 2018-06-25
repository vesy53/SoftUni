using System;
using System.Linq;

namespace p09JumpAround
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = 0;
            long sum = 0L;

            while (index >= 0)
            {
                if (index < arr.Length)
                {
                    sum += arr[index];

                    index = index + arr[index] < arr.Length ?
                        index + arr[index] :
                        index - arr[index];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
