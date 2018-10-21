namespace p04._01.SoftUniCoffeeSupplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftUniCoffeeSupplies
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();
            var dataQuantities = new Dictionary<string, int>();

            string[] delimiters = Console.ReadLine()
                .Split();
            string firstDelimiter = delimiters[0];
            string secondDelimiter = delimiters[1];
            string input = Console.ReadLine();

            while (input.Equals("end of info") == false)
            {
                if (input.Contains(firstDelimiter))
                {
                    string[] tokens = input
                        .Split(new string[] { firstDelimiter },
                            StringSplitOptions
                            .RemoveEmptyEntries);
                    string personName = tokens[0];
                    string coffeeType = tokens[1];

                    if (!data.ContainsKey(personName))
                    {
                        data.Add(personName, string.Empty);
                    }

                    data[personName] = coffeeType;
                }
                else if (input.Contains(secondDelimiter))
                {
                    string[] tokens = input
                        .Split(new string[] { secondDelimiter },
                            StringSplitOptions
                            .RemoveEmptyEntries);
                    string coffeeType = tokens[0];
                    int quantity = int.Parse(tokens[1]);

                    if (!dataQuantities.ContainsKey(coffeeType))
                    {
                        dataQuantities.Add(coffeeType, 0);
                    }

                    dataQuantities[coffeeType] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var item in data
                .Select(x => x.Value))
            {
                string coffeeType = item;

                if (!dataQuantities.ContainsKey(coffeeType))
                {
                    Console.WriteLine($"Out of {coffeeType}");
                }
            }
           
            foreach (var item in dataQuantities
                .Where(x => x.Value <= 0))
            {
                string coffeeType = item.Key;

                Console.WriteLine($"Out of {coffeeType}");
            }

            string line = Console.ReadLine();

            while (line.Equals("end of week") == false)
            {
                string[] tokensLine = line
                    .Split();
                string personName = tokensLine[0];
                int quantity = int.Parse(tokensLine[1]);

                string coffeeType = data[personName];

                dataQuantities[coffeeType] -= quantity;

                if (dataQuantities[coffeeType] <= 0)
                {
                    Console.WriteLine($"Out of {coffeeType}");

                    dataQuantities[coffeeType] = 0;
                }
                
                line = Console.ReadLine();
            }

            Console.WriteLine("Coffee Left:");

            foreach (var dataQuantity in dataQuantities
                .Where(x => x.Value > 0)
                .OrderByDescending(x => x.Value))
            {
                string coffeeType = dataQuantity.Key;
                int quantity = dataQuantity.Value;

                Console.WriteLine($"{coffeeType} {quantity}");
            }

            Console.WriteLine("For:");

            foreach (var dataQuantity in dataQuantities
                .Where(x => x.Value > 0)
                .OrderBy(x => x.Key)
                .Select(x => x.Key)
                .ToList())
            {
                foreach (var itemData in data
                    .Where(x => x.Value == dataQuantity)
                    .OrderByDescending(x => x.Key))
                {
                    string personName = itemData.Key;
                    string coffeeType = itemData.Value;

                    Console.WriteLine($"{personName} {coffeeType}");
                }
            }
        }
    }
}
