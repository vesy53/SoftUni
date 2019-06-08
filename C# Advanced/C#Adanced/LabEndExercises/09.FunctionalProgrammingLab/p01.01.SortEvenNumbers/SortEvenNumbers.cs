namespace p01._01.SortEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], List<int>> resultFunc = TakeEvenNumbers;
            
            Console.WriteLine(string.Join(", ", resultFunc(numbers)));
        }

        private static List<int> TakeEvenNumbers(int[] numbers)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    evenNumbers.Add(currentNumber);
                }
            }

            evenNumbers.Sort();

            return evenNumbers;
        }
    }
}
