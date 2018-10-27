using System;
using System.Collections.Generic;
using System.Linq;

class LegendaryFarming3
{
    static void Main(string[] args)
    {
        var junkMaterials = new SortedDictionary<string, int>();
        var keyMaterials = new Dictionary<string, int>();

        keyMaterials["shards"] = 0;
        keyMaterials["fragments"] = 0;
        keyMaterials["motes"] = 0;

        var namesMaterials = new Dictionary<string, string>();
        namesMaterials.Add("shards", "Shadowmourne");
        namesMaterials.Add("fragments", "Valanyr");
        namesMaterials.Add("motes", "Dragonwrath");

        string[] input = Console.ReadLine()
            .ToLower()
            .Split()
            .ToArray();

        while (true)
        {
            int[] quantity = input
                .Where((x, y) => y % 2 == 0)
                .Select(int.Parse)
                .ToArray();
            string[] material = input
                .Where((x, y) => y % 2 == 1)
                .ToArray();

            bool hasObtained = false;

            for (int i = 0; i < material.Length; i++)
            {
                string currentMaterial = material[i];

                if (namesMaterials.Keys.Contains(currentMaterial))
                {
                    keyMaterials[currentMaterial] += quantity[i];

                    if (keyMaterials.Values.Any(x => x >= 250))
                    {
                        hasObtained = true;
                        break;
                    }
                }
                else
                {
                    if (!junkMaterials.ContainsKey(currentMaterial))
                    {
                        junkMaterials.Add(currentMaterial, 0);
                    }

                    junkMaterials[currentMaterial] += quantity[i];
                }

                if (hasObtained)
                {
                    break;
                }
            }

            if (hasObtained)
            {
                break;
            }

            input = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();
        }

        string obtainedElementName = keyMaterials
           .Where(x => x.Value >= 250)
           .First()
           .Key
           .ToString();

        keyMaterials[obtainedElementName] -= 250;

        keyMaterials = keyMaterials
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        Console.WriteLine($"{namesMaterials[obtainedElementName]} obtained!");

        var result = keyMaterials
            .Concat(junkMaterials)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var material in result)
        {
            Console.WriteLine($"{material.Key}: {material.Value}");
        }
    }
}

