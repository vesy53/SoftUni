using System;
using System.Collections.Generic;
using System.Linq;

class LegendaryFarming2
{
    static void Main(string[] args)
    {
        var keyMaterials = new Dictionary<string, int>();
        var junkMaterials = new SortedDictionary<string, int>();

        keyMaterials["shards"] = 0;
        keyMaterials["fragments"] = 0;
        keyMaterials["motes"] = 0;

        bool isTrue = true;
        string nameMaterial = string.Empty;

        while (isTrue)
        {
            List<string> input = Console.ReadLine()
                .ToLower()
                .Split()
                .ToList();

            for (int i = 0; i < input.Count - 1; i += 2)
            {
                int quantity = int.Parse(input[i]);
                string material = input[i + 1];

                if (keyMaterials.ContainsKey(material))
                {
                    keyMaterials[material] += quantity;
                }
                else
                {
                    if (!junkMaterials.ContainsKey(material))
                    {
                        junkMaterials.Add(material, 0);
                    }

                    junkMaterials[material] += quantity;
                }

                if (keyMaterials.ContainsKey(material) && keyMaterials[material] >= 250)
                {
                    keyMaterials[material] -= 250;
                    nameMaterial = material;
                    isTrue = false;
                    break;
                }
            }
        }

        switch (nameMaterial)
        {
            case "shards":
                Console.WriteLine("Shadowmourne obtained!");
                break;
            case "fragments":
                Console.WriteLine("Valanyr obtained!");
                break;
            case "motes":
                Console.WriteLine("Dragonwrath obtained!");
                break;
        }

        foreach (var item in keyMaterials
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key))
        {
            string material = item.Key;
            int quantity = item.Value;

            Console.WriteLine($"{material}: {quantity}");
        }

        foreach (var junk in junkMaterials)
        {
            string material = junk.Key;
            int quantity = junk.Value;

            Console.WriteLine($"{material}: {quantity}");
        }
    }
}

