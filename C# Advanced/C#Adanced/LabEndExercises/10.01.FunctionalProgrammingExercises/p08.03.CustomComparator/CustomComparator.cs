namespace p08._03.CustomComparator
{
    using System;
    using System.Linq;

    class CustomComparator
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Predicate<int> isEven = n => n % 2 == 0;

            int[] evenNums = numbers
                .Where(x => isEven(x))
                .ToArray();
            int[] oddNums = numbers
                .Where(x => !isEven(x))
                .ToArray();

            Array.Sort(evenNums);
            Array.Sort(oddNums);

            Console.WriteLine(
                string.Join(" ", evenNums.Concat(oddNums)));
        }
    }
}
