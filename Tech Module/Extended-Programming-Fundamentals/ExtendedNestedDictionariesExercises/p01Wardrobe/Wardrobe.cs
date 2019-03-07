using System;
using System.Collections.Generic;

class Wardrobe
{
    static void Main(string[] args)
    {
        var boxClothes = new Dictionary<string, Dictionary<string, int>>();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split(new string[] { " -> " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string color = inputTokens[0];
            string[] clothes = inputTokens[1]
                .Split(',');

            if (!boxClothes.ContainsKey(color))
            {
                boxClothes.Add(color, new Dictionary<string, int>());
            }

            foreach (var cloth in clothes)
            {
                if (!boxClothes[color].ContainsKey(cloth))
                {
                    boxClothes[color].Add(cloth, 1);
                }
                else
                {
                    boxClothes[color][cloth]++;
                }
            }     
        }

        string[] searchData = Console.ReadLine()
            .Split();

        string searchColor = searchData[0];
        string searchClothes = searchData[1];

        foreach (var clothesData in boxClothes)
        {
            string color = clothesData.Key;
            Dictionary<string, int> clothes = clothesData.Value;

            Console.WriteLine($"{color} clothes:");

            foreach (var cloth in clothes)
            {
                string clothesName = cloth.Key;
                int numCount = cloth.Value;

                Console.Write($"* {clothesName} - {numCount}");

                if (searchColor == color && searchClothes == clothesName)
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

