using System;
using System.Linq;

namespace p09JumpAround1
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
            int sum = 0;

            while (index >= 0)
            {
                if (index < arr.Length)
                {
                    sum += arr[index];

                    if (index + arr[index] < arr.Length)
                    {
                        index += arr[index];
                    }
                    else
                    {
                        index -= arr[index];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
