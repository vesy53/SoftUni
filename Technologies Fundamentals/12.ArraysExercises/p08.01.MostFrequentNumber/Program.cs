using System;
using System.Linq;

namespace p08MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int longestOccurance = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        counter++;
                    }
                }

                if (counter > longestOccurance)
                {
                    longestOccurance = counter;
                    mostFrequentNumber = arr[i];
                }
            }

            Console.WriteLine(mostFrequentNumber);
        }
    }
}
