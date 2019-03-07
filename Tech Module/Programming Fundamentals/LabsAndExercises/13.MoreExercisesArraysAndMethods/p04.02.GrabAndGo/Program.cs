using System;
using System.Linq;

namespace p04GrabAndGo1
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

            int index = 0;
            bool isFound = false;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == numToSearch)
                {
                    index = i;
                    isFound = true;
                    break;
                }
            }

            long sum = 0L;

            if (isFound)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
