namespace p06._01.Wardrobe
{
    using System;
    using System.Collections.Generic;

    class Wardrobe
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ");

                string color = input[0];
                string[] clothes = input[1]
                    .Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentCloth = clothes[j];

                    if (!wardrobe[color].ContainsKey(currentCloth))
                    {
                        wardrobe[color].Add(currentCloth, 0);
                    }

                    wardrobe[color][currentCloth]++;
                }
            }

            string[] searchArgs = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string searchColor = searchArgs[0];
            string searchClothe = searchArgs[1];

            foreach (var data in wardrobe)
            {
                string color = data.Key;
                Dictionary<string, int> clothes = data.Value;

                Console.WriteLine($"{color} clothes:");

                foreach (var item in clothes)
                {
                    string cloth = item.Key;
                    int count = item.Value;

                    if (color.Equals(searchColor) &&
                        cloth.Equals(searchClothe))
                    {
                        Console.WriteLine(
                            $"* {cloth} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {count}");
                    }
                }
            }
        }
    }
}
