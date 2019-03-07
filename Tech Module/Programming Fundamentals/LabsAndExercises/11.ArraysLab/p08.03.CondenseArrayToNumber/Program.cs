using System;
using System.Linq;

namespace p08CondenseArrayToNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int[] condensed = new int[arr.Length - 1];

                for (int j = 0; j < condensed.Length; j++)
                {
                    condensed[j] = arr[j] + arr[j + 1];
                }

                arr = condensed;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
