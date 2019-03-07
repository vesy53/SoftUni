using System;

namespace p10CountOfNegativeElementsInArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            int count = CountOfNegativeElementsInArray(num, arr); 
        
            Console.WriteLine(count);
        }

        static int CountOfNegativeElementsInArray(int num, int[] arr)
        {
            int count = 0;

            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
