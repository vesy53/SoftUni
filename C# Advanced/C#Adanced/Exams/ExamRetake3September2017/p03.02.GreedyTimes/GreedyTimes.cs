namespace p03._02.GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GreedyTimes
    {
        static void Main(string[] args)
        {
            var treasursData = new Dictionary<string, Dictionary<string, long>>();

            treasursData.Add("Gold", new Dictionary<string, long>());
            treasursData.Add("Gem", new Dictionary<string, long>());
            treasursData.Add("Cash", new Dictionary<string, long>());

            long capacityOfTheBag = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            long sumGold = 0;
            long sumGem = 0;
            long sumCash = 0;
            long currBag = 0;

            for (int i = 0; i < input.Length; i += 2)
            {
                string treasure = input[i];
                long value = long.Parse(input[i + 1]);

                if (!IsBelowBagCapacity(capacityOfTheBag, currBag + value))
                {
                    continue;
                }

                if (treasure == "Gold")
                {
                    SaveTreasure(treasursData["Gold"], treasure, value);
                    sumGold += value;
                    currBag += value;
                }
                else if (treasure.Length == 3)
                {
                    bool balanced = IsBalanceKept(sumCash + value, sumGem);
                    if (balanced)
                    {
                        SaveTreasure(treasursData["Cash"], treasure, value);
                        sumCash += value;
                        currBag += value;
                    }
                }
                else if (treasure.ToLower().EndsWith("gem"))
                {
                    bool balanced = IsBalanceKept(sumGem + value, sumGold);

                    if (balanced)
                    {
                        SaveTreasure(treasursData["Gem"], treasure, value);
                        sumGem += value;
                        currBag += value;
                    }
                }
            }

            PrintResult(treasursData);
        }

        static void PrintResult(
            Dictionary<string, Dictionary<string, long>> treasursData)
        {
            foreach (var data in treasursData
                .Where(x => x.Value.Count > 0)
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

        static bool IsBelowBagCapacity
            (long capacityOfTheBag,
            long currBag)
        {
            return capacityOfTheBag <= currBag;
        }

        static bool IsBalanceKept(
            long first, 
            long second)
        {
            return first <= second;
        }

        static void SaveTreasure(
            Dictionary<string, long> dictionary,
            string treasure,
            long value)
        {
            if (!dictionary.ContainsKey(treasure))
            {
                dictionary.Add(treasure, 0);
            }

            dictionary[treasure] += value;
        }

    }
}