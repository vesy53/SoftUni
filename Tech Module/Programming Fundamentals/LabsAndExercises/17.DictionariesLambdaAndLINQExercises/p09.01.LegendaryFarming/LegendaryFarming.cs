using System;
using System.Linq;
using System.Collections.Generic;

class LegendaryFarming
{
    static void Main(string[] args)
    {
        var keyMaterials = new Dictionary<string, int>();
        var junkMaterials = new Dictionary<string, int>();
        bool isTrue = true;
        string obtained = string.Empty;

        keyMaterials.Add("shards", 0);
        keyMaterials.Add("fragments", 0);
        keyMaterials.Add("motes", 0);

        while (isTrue)
        {
            string input = Console.ReadLine();
            string[] inputTokens = input
                .Split();

            for (int i = 0; i < inputTokens.Length - 1; i += 2)
            {
                int quantity = int.Parse(inputTokens[i]);
                string material = inputTokens[i + 1].ToLower();

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

                if (keyMaterials["shards"] >= 250)
                {
                    keyMaterials[material] -= 250;
                    obtained = "Shadowmourne";
                    isTrue = false;
                    break;
                }
                else if (keyMaterials["fragments"] >= 250)
                {
                    keyMaterials[material] -= 250;
                    obtained = "Valanyr";
                    isTrue = false;
                    break;
                }
                else if (keyMaterials["motes"] >= 250)
                {
                    keyMaterials[material] -= 250;
                    obtained = "Dragonwrath";
                    isTrue = false;
                    break;
                }
            }
        }

        Console.WriteLine($"{obtained} obtained!");

        foreach (var item in keyMaterials
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key))
        {
            string material = item.Key;
            int quantity = item.Value;

            Console.WriteLine($"{material}: {quantity}");
        }

        foreach (var junk in junkMaterials
            .OrderBy(x => x.Key))
        {
            string material = junk.Key;
            int quantity = junk.Value;

            Console.WriteLine($"{material}: {quantity}");
        }
    }
}

