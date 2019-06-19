namespace p03._01.GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GreedyTimes
    {
        static void Main(string[] args)
        {
            var treasursData = new Dictionary<string, Dictionary<string, long>>();

            long capacityOfTheBag = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            long gold = 0;
            long gem = 0;
            long cash = 0;
            long currBag = 0;
            string key = string.Empty;

            for (int i = 0; i < input.Length; i += 2)
            {
                string treasure = input[i];
                long value = long.Parse(input[i + 1]);

                if (value >= capacityOfTheBag)
                {
                    continue;
                }

                if (treasure == "Gold")
                {
                    key = "Gold";
                    gold += value;
                    bool isValid = IsValid(capacityOfTheBag, gold, gem, currBag, value);

                    TakeTreasurs(treasursData, ref gold, ref currBag, key, treasure, value, isValid);
                }
                else if (treasure.ToLower().EndsWith("gem")
                    && treasure.Length > 3)
                {
                    key = "Gem";
                    gem += value;
                    bool isValid = IsValid(capacityOfTheBag, gold, gem, currBag, value);

                    TakeTreasurs(treasursData, ref gem, ref currBag, key, treasure, value, isValid);
                }
                else if (treasure.Length == 3)
                {
                    key = "Cash";
                    cash += value;
                    bool isValid = IsValid(capacityOfTheBag, gem, cash, currBag, value);

                    TakeTreasurs(treasursData, ref cash, ref currBag, key, treasure, value, isValid);
                }
            }

            PrintResult(treasursData);
        }

        private static void PrintResult(
            Dictionary<string, Dictionary<string, long>> treasursData)
        {
            foreach (var data in treasursData
                .OrderByDescending(x => x.Value.Values.Sum()))
            {
                string treasursType = data.Key;
                Dictionary<string, long> elements = data.Value;
                long totalSum = elements.Values.Sum();

                Console.WriteLine($"<{treasursType}> ${totalSum}");

                foreach (var element in elements
                    .OrderByDescending(x => x.Key)
                    .ThenBy(x => x.Value))
                {
                    string name = element.Key;
                    long quantity = element.Value;

                    Console.WriteLine($"##{name} - {quantity}");
                }
            }
        }

        static bool IsValid(
            long capacityOfTheBag,
            long first, 
            long second, 
            long currBag, 
            long value)
        {
            return first >= second &&
                (currBag + value) <= capacityOfTheBag;
        }

        private static void TakeTreasurs(
            Dictionary<string, Dictionary<string, long>> treasursData,
            ref long refTreasurs,
            ref long currBag,
            string key,
            string treasure,
            long value,
            bool isValid)
        {
            if (isValid)
            {
                currBag += value;

                if (!treasursData.ContainsKey(key))
                {
                    treasursData.Add(key, new Dictionary<string, long>());
                }

                if (!treasursData[key].ContainsKey(treasure))
                {
                    treasursData[key].Add(treasure, 0);
                }

                treasursData[key][treasure] += value;
            }
            else
            {
                refTreasurs -= value;
            }
        }
    }
}