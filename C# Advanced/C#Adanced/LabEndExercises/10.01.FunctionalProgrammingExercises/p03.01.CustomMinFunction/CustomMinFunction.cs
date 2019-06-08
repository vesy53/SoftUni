namespace p03._01.CustomMinFunction
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

            Func<int[], int> minElementFunc = TakeMinElement;

            Console.WriteLine(minElementFunc(numbers));
        }

        private static int TakeMinElement(int[] numbers)
        {
            int minNumber = int.MaxValue; 

            foreach (int number in numbers)
            {
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            return minNumber;
        }
    }
}
