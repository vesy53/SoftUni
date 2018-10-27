﻿namespace p04._01.PokemonEvolution
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var data = new Dictionary<string, List<Pokemon>>();

            while (input != "wubbalubbadubdub")
            {
                string[] pokemonArgs = input
                    .Split(new string[] { " -> " }, 
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = pokemonArgs[0];

                if (pokemonArgs.Length == 1)
                {
                    foreach (var itemData in data
                        .Where(x => x.Key == name))
                    {
                        string namePokemon = itemData.Key;
                        List<Pokemon> evolutions = itemData.Value;

                        Console.WriteLine($"# {name}");

                        foreach (Pokemon evolution in evolutions)
                        {
                            string typeEvol = evolution.Type;
                            int indexEvol = evolution.Index;

                            Console.WriteLine($"{typeEvol} <-> {indexEvol}");
                        }
                    } 
                }
                else
                {
                    string type = pokemonArgs[1];
                    int index = int.Parse(pokemonArgs[2]);

                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<Pokemon>());
                    }

                    Pokemon newPokemon = new Pokemon
                    (
                        type,
                        index
                    );

                    data[name].Add(newPokemon);
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data)
            {
                string name = itemData.Key;
                List<Pokemon> evolutions = itemData.Value;

                Console.WriteLine($"# {name}");

                foreach (Pokemon evolution in evolutions
                    .OrderByDescending(x => x.Index))
                {
                    string type = evolution.Type;
                    int index = evolution.Index;

                    Console.WriteLine($"{type} <-> {index}");
                }
            }
        }
    }

    class Pokemon
    {
        public string Type { get; set; }
        public int Index { get; set; }

        public Pokemon
            (string type,
            int index)
        {
            this.Type = type;
            this.Index = index;
        }
    }
}
