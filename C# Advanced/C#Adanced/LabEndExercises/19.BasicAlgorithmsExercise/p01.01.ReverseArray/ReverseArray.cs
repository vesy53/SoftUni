namespace p01._01.ReverseArray
{
    using System;
    using System.Linq;

    public class ReverseArray
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            ReverseArrayWithRecursion(numbers, 0, numbers.Length - 1);
            
            Console.WriteLine(string.Join(" ", numbers));
        }

        public static void ReverseArrayWithRecursion(
            int[] arr,
            int start,
            int end)
        {
            if (start >= end)
            {
                return;
            }

            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            ReverseArrayWithRecursion(arr, start + 1, end - 1);
        }

        public static void ReverseArrayWithForLoop(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[arr.Length - i - 1];
                int first = arr[i];

                arr[i] = temp;
                arr[arr.Length - i - 1] = first;
            }
        }

        // method without Recursion
        public static void ReverseArrayForLoop(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
