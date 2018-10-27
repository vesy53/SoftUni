using System;
using System.Linq;

namespace p09ExtractMiddleElements1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] result = ExtractMiddleElements(arr);

            Console.WriteLine("{ " + string.Join(", ", result) + " }");
        }

        static int[] ExtractMiddleElements(int[] arr)
        {
            int[] result = new int[0];

            if (arr.Length == 1)
            {
                result = new int[1];
                result[0] = arr[0];
            }
            else if (arr.Length % 2 == 1)
            {
                result = new int[3];
                result[0] = arr[arr.Length / 2 - 1];
                result[1] = arr[arr.Length / 2];
                result[2] = arr[arr.Length / 2 + 1];
            }
            else if (arr.Length % 2 == 0)
            {
                result = new int[2];
                result[0] = arr[arr.Length / 2 - 1];
                result[1] = arr[arr.Length / 2];
            }

            return result;
        }
    }
}
