namespace p01._04.ReverseArray
{
    using System;
    using System.Linq;

    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ',
                   StringSplitOptions
                   .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            RecursiveReversArray(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void RecursiveReversArray(int[] numbers)
        {
            int lower = 0;
            int upper = numbers.Length - 1;

            for (int i = lower, j = upper; i < j; i++, j--)
            {
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
    }
}