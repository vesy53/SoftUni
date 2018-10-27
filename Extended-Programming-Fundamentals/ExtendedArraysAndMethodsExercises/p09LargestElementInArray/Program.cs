using System;

namespace p09LargestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] arr = new int[number];
            int max = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}
