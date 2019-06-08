namespace p05._01.CountSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountSymbols
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<char, int>();

            string text = Console.ReadLine();

            foreach (char symbol in text)
            {
                if (!data.ContainsKey(symbol))
                {
                    data.Add(symbol, 0);
                }

                data[symbol]++;
            }

            foreach (var itemData in data
                .OrderBy(i => i.Key))
            {
                char symbpl = itemData.Key;
                int count = itemData.Value;

                Console.WriteLine(
                    $"{symbpl}: {count} time/s");
            }
        }
    }
}
