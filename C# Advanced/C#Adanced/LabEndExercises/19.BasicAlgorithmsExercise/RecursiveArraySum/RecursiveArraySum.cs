namespace RecursiveArraySum
{
    using System;
    using System.Linq;

    class RecursiveArraySum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = SumElementsInTheArray(numbers, 0);

            Console.WriteLine(sum);
        }

        private static int SumElementsInTheArray(
            int[] numbers, 
            int index)
        {
            if (index == numbers.Length - 1)
            {
                return numbers[index];
            }

            return numbers[index] + 
                   SumElementsInTheArray(numbers, index + 1);
        }
    }
}
