using System;
using System.Linq;

namespace p08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int i = 0;

            while (arr.Length > 1)
            {
                int[] condensed = new int[arr.Length - 1];

                while (i != condensed.Length)
                {
                    condensed[i] = arr[i] + arr[i + 1];
                    i++;
                }

                arr = condensed;
                i = 0;
            }

            Console.WriteLine(string.Join(" ", arr));          
        }
    }
}
