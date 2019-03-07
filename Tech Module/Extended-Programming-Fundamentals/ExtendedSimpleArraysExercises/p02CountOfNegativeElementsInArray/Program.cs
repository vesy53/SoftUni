using System;

namespace p02CountOfNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] arr = new int[number];
            int count = 0;

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
