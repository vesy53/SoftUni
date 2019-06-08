namespace p11._01.PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            
            string input = Console.ReadLine();

            while (input.Equals("Tournament") == false)
            {
                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string element = tokens[2];
                int health = int.Parse(tokens[3]);

                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                Trainer searchTrainers = trainers
                    .Where(t => t.Name == trainerName)
                    .FirstOrDefault();

                if (searchTrainers == null)
                {
                    searchTrainers = new Trainer(trainerName);

                    trainers.Add(searchTrainers);
                }

                searchTrainers.AddPokemon(pokemon);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input.Equals("End") == false)
            {
                foreach (Trainer trainer in trainers)
                {
                    bool isValid = trainer.Pokemons.Any(p => p.Element == input);

                    if (isValid)
                    {
                        trainer.AddBadge();
                        continue;
                    }

                    trainer.DecreasePokeHealth();
                    trainer.RemovePokemons();
                }

                input = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers
                .OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine(trainer.ToString());
            }
        }
    }
}
