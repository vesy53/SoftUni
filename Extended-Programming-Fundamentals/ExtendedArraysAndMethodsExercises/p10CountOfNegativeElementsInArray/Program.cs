using System;

namespace p10CountOfNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];
            int count = 0;

            for (int i = 0; i < num; i++)
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
