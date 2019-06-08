namespace p03._02.CustomMinFunction
{
    using System;
    using System.Linq;

    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minNumber = n => n.Min();

            Console.WriteLine(minNumber(numbers));
        }
    }
}