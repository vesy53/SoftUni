namespace p01._01.CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> data = new Dictionary<double, int>();

            double[] numbers = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNum = numbers[i];

                if (!data.ContainsKey(currentNum))
                {
                    data.Add(currentNum, 1);
                }
                else
                {
                    data[currentNum]++;
                }
            }

            foreach (var itemData in data)
            {
                double number = itemData.Key;
                int count = itemData.Value;

                Console.WriteLine($"{number} - {count} times");
            }
        }
    }
}
