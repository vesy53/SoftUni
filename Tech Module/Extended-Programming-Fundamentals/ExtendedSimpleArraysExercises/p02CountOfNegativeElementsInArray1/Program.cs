using System;
using System.Linq;

namespace p02CountOfNegativeElementsInArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] arr = new int[number];

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int countNegativeNum = arr.Where(x => x < 0).Count();

            Console.WriteLine(countNegativeNum);
        }
    }
}
