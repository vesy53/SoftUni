namespace p05._03.CountSymbols
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class CountSymbols
    {
        static void Main(string[] args)
        {
            var data = new SortedDictionary<char, int>();

            List<char> input = Console.ReadLine()
                .ToCharArray()
                .ToList();

            input.ForEach(x =>
            {
                if (!data.ContainsKey(x))
                {
                    data.Add(x, 0);
                }

                data[x]++;
            });

            foreach (var itemData in data)
            {
                char currChar = itemData.Key;
                int count = itemData.Value;

                Console.WriteLine(
                    $"{currChar}: {count} time/s");
            }
        }
    }
}
