using System;

namespace p09LargestElementInArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] arr = new int[number];
            
            int max = LargestElementInArray(number, arr);

            Console.WriteLine(max);
        }

        static int LargestElementInArray(int number, int[] arr)
        {
            int max = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
}
