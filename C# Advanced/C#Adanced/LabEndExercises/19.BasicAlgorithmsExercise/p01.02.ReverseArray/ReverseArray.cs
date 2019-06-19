namespace p01._02.ReverseArray
{
    using System;
    using System.Linq;

    class ReverseArray
    {
        static int[] numbers;

        static void Main(string[] args)
        {
            numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            PrintInReverseOrder(numbers.Length - 1);

            Console.WriteLine();

            //ReverseArrayForLoop();
        }

        private static void PrintInReverseOrder(int index)
        {
            if (index < 0)
            {
                return;
            }

            Console.Write(numbers[index] + " ");

            PrintInReverseOrder(index - 1);
        }

        // method without Recursion
        public static void ReverseArrayForLoop()
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }

    }
}
