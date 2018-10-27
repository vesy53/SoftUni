using System;
using System.Linq;

namespace p14EqualSequenceOfElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isEqual = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    isEqual = false;
                    break;
                }
            }

            Console.WriteLine(isEqual ? "Yes" : "No");
        }
    }
}
