namespace p11._01.PokemonTrainer
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Trainer
    {
        private const int DefaultBadges = 0;

        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = DefaultBadges;

            this.Pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int NumberOfBadges
        {
            get => this.numberOfBadges;
            set => this.numberOfBadges = value;
        }

        public List<Pokemon> Pokemons
        {
            get => this.pokemons;
            set => this.pokemons = value;
        }

        public void AddBadge()
        {
            this.NumberOfBadges++;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public void DecreasePokeHealth()
        {
            this.Pokemons
                .ForEach(p => p.Health -= 10);
        }

        public void RemovePokemons()
        {
            this.Pokemons = this.Pokemons
                .Where(p => p.Health > 0)
                .ToList();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            
            builder.AppendLine(
                $"{this.Name} {this.NumberOfBadges} {this.Pokemons.Count}");

            return builder.ToString().TrimEnd();
        }
    }
}
