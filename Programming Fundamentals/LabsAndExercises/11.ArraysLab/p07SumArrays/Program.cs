using System;
using System.Linq;

namespace p07SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] secondArr = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            int max = Math.Max(firstArr.Length, secondArr.Length);
            int firstArrLength = firstArr.Length;
            int secArrLength = secondArr.Length;
            int[] sumArr = new int[max];
            //second method
            //int sum = 0;
            for (int i = 0; i < max; i++)
            {
                sumArr[i] = firstArr[i % firstArrLength] + secondArr[i % secArrLength];

                //sum = firstArr[i % firstArrLength] + secondArr[i % secArrLength];
                //Console.Write(sum + " ");
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
