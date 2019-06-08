namespace p06._02.Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Wardrobe
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int linesOfClothes = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesOfClothes; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> " },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string color = input[0];
                List<string> clothes = input[1]
                    .Split(',')
                    .ToList();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (string dress in clothes)
                {
                    if (!wardrobe[color].ContainsKey(dress))
                    {
                        wardrobe[color].Add(dress, 0);
                    }

                    wardrobe[color][dress]++;
                }
            }

            string[] tokens = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string searchColor = tokens[0];
            string searchDress = tokens[1];
            bool isSearch = false;

            foreach (var item in wardrobe)
            {
                string color = item.Key;
                Dictionary<string, int> clothes = item.Value;

                isSearch = searchColor == color ?
                    true :
                    false;

                Console.WriteLine($"{color} clothes:");

                foreach (var cloth in clothes)
                {
                    string dress = cloth.Key;
                    int count = cloth.Value;

                    string result = string.Format($"* {dress} - {count}");

                    if (isSearch && dress == searchDress)
                    {
                        result += string.Format($" (found!)");
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}