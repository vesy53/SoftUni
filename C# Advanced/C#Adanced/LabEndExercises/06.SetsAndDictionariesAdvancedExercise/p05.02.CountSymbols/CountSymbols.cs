namespace p05._02.CountSymbols
{
    using System;
    using System.Collections.Generic;

    class CountSymbols
    {
        static void Main(string[] args)
        {
            var data = new SortedDictionary<char, int>();

            char[] text = Console.ReadLine()
                .ToCharArray();

            foreach (var symbol in text)
            {
                if (!data.ContainsKey(symbol))
                {
                    data.Add(symbol, 0);
                }

                data[symbol]++;
            }

            foreach (var itemData in data)
            {
                char symbpl = itemData.Key;
                int count = itemData.Value;

                Console.WriteLine(
                    $"{symbpl}: {count} time/s");
            }
        }
    }
}
