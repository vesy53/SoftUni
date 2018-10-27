using System;
using System.Linq;

namespace p10CountOfNegativeElementsInArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            var negativeNumCount = arr.Where(x => x < 0).Count();

            Console.WriteLine(negativeNumCount);
        }
    }
}
