using System;
using System.Collections.Generic;

class Wardrobe2
{
    static void Main(string[] args)
    {
        var boxClothes = new Dictionary<string, Dictionary<string, int>>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split(new string[] { " -> " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string color = inputTokens[0];
            string[] clothes = inputTokens[1]
                .Split(',');

            StoreColorData(boxClothes, color, clothes);
        }

        string[] searchTokens = Console.ReadLine()
            .Split();

        string searchColor = searchTokens[0];
        string searchClothes = searchTokens[1];

        foreach (var item in boxClothes)
        {
            string color = item.Key;
            Dictionary<string, int> clothesData = item.Value;

            PrintColorData(color, clothesData, searchColor, searchClothes);
        }
    }

    static void PrintColorData(
        string color, 
        Dictionary<string, int> clothesData, 
        string searchColor, 
        string searchClothes)
    {
        Console.WriteLine($"{color} clothes:");

        foreach (var item in clothesData)
        {
            string clothes = item.Key;
            int numCount = item.Value;

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

    static void StoreColorData(
        Dictionary<string, Dictionary<string, int>> boxClothes,
        string color,
        string[] clothes)
    {
        if (!boxClothes.ContainsKey(color))
        {
            boxClothes.Add(color, new Dictionary<string, int>());
        }

        foreach (var item in clothes)
        {
            if (!boxClothes[color].ContainsKey(item))
            {
                boxClothes[color].Add(item, 0);
            }

            boxClothes[color][item]++;
        }
    }
}

