namespace p04._03.PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PokemonEvolution3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var data = new Dictionary<string, List<string>>();

            while (input.Equals("wubbalubbadubdub") == false)
            {
                string[] pokemonArgs = input
                    .Split(new string[] { " -> " },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = pokemonArgs[0];

                if (pokemonArgs.Length == 1  &&
                    data.ContainsKey(name))
                {
                    Console.WriteLine($"# {name}");

                    foreach (var itemData in data[name])
                    {
                        string[] currentPair = itemData.Split();
                        string type = currentPair[0];
                        int currentIndex = int.Parse(currentPair[1]);

                        Console.WriteLine($"{type} <-> {currentIndex}");
                    }
                }
                else
                {
                    string type = pokemonArgs[1];
                    long index = long.Parse(pokemonArgs[2]);

                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<string>());
                    }

                    data[name].Add(type + " " + index);
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data)
            {
                string name = itemData.Key;

                Console.WriteLine($"# {name}");

                foreach (var evolution in itemData.Value
                    .OrderByDescending(x => int.Parse(x.Split()[1])))
                {
                    string[] result = evolution.Split();

                    Console.WriteLine($"{result[0]} <-> {result[1]}");
                }
            }
        }
    }
}
