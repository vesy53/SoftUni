using System;
using System.Linq;

namespace p09ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string result = ExtractMiddleElements(arr);

            Console.WriteLine("{ " + $"{string.Join(", ", result)}" + " }");
        }

        static string ExtractMiddleElements(int[] arr)
        {
            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length == 1)
                {
                    result = $"{arr[0]}";
                }
                else if (arr.Length % 2 == 1)
                {
                    result = $"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}, {arr[arr.Length / 2 + 1]}";
                }
                else if (arr.Length % 2 == 0)
                {
                    result = $"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}";
                }
            }

            return result;
        }
    }
}
