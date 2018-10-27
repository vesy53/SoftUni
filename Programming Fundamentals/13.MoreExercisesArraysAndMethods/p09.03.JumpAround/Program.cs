using System;
using System.Linq;

namespace p09JumpAround2
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

            while (true)
            {   //jump to right
                int tempIndex = index;
                sum += arr[index];
                index += arr[index];

                if (index > arr.Length - 1) //jump to left
                {
                    index = tempIndex - arr[tempIndex];

                    if (index < 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
