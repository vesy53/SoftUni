using System;
using System.Collections.Generic;
using System.Linq;

class Wardrobe1
{
    static void Main(string[] args)
    {
        var wardrobe = new Dictionary<string, Dictionary<string, int>>();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            List<string> inputTokens = Console.ReadLine()
                .Split(new string[] { " -> " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToList();

            string color = inputTokens[0];
            List<string> clothes = inputTokens[1]
                .Split(',')
                .ToList();

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, int>());
            }

            foreach (var item in clothes)
            {
                if (!wardrobe[color].ContainsKey(item))
                {
                    wardrobe[color].Add(item, 0);
                }

                wardrobe[color][item]++;
            }
        }

        List<string> searchCommand = Console.ReadLine()
            .Split()
            .ToList();

        string searchColor = searchCommand[0];
        string searchClothes = searchCommand[1];

        foreach (var item in wardrobe)
        {
            string color = item.Key;
            Dictionary<string, int> clothesData = item.Value;

            Console.WriteLine($"{color} clothes:");

            foreach (var itemClothes in clothesData)
            {
                string clothes = itemClothes.Key;
                int numCount = itemClothes.Value;

                Console.Write($"* {clothes} - {numCount}");

                if (searchColor == color && searchClothes == clothes)
                {
                    Console.WriteLine(" (found!)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

