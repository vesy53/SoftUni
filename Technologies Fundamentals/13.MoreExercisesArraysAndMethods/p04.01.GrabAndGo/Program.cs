using System;
using System.Linq;

namespace p04GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int numToSearch = int.Parse(Console.ReadLine());

            long sum = 0L;
            bool isSearch = false;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int currentNum = arr[i];

                if (currentNum == numToSearch)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sum += arr[j];
                        isSearch = true;
                    }

                    break;
                }             
            }

            if (isSearch)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
