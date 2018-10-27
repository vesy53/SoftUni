using System;

namespace p01SumArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] arr = new int[number];
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                sum += arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}
