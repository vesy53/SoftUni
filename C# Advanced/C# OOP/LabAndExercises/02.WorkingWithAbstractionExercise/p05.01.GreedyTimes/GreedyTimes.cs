namespace p05._01.GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GreedyTimes
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();

            long capacityOfTheBag = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, 
                    StringSplitOptions
                    .RemoveEmptyEntries);

            long gold = 0;
            long gem = 0;
            long cash = 0;

            for (int i = 0; i < input.Length; i += 2)
            {
                string name = input[i];
                long quantity = long.Parse(input[i + 1]);

                string itemName = string.Empty;

                if (name.Length == 3)
                {
                    itemName = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    itemName = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    itemName = "Gold";
                }

                if (itemName == "")
                {
                    continue;
                }
                else if (capacityOfTheBag < data.Values.Select(x => x.Values.Sum()).Sum() + quantity)
                {
                    continue;
                }

                switch (itemName)
                {
                    case "Gem":
                        if (!data.ContainsKey(itemName))
                        {
                            if (data.ContainsKey("Gold"))
                            {
                                if (quantity > data["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (data[itemName].Values.Sum() + quantity > data["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!data.ContainsKey(itemName))
                        {
                            if (data.ContainsKey("Gem"))
                            {
                                if (quantity > data["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (data[itemName].Values.Sum() + quantity > data["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!data.ContainsKey(itemName))
                {
                    data[itemName] = new Dictionary<string, long>();
                }

                if (!data[itemName].ContainsKey(name))
                {
                    data[itemName][name] = 0;
                }

                data[itemName][name] += quantity;
                if (itemName == "Gold")
                {
                    gold += quantity;
                }
                else if (itemName == "Gem")
                {
                    gem += quantity;
                }
                else if (itemName == "Cash")
                {
                    cash += quantity;
                }
            }

            foreach (var x in data)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");

                foreach (var item2 in x.Value
                    .OrderByDescending(y => y.Key)
                    .ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}
