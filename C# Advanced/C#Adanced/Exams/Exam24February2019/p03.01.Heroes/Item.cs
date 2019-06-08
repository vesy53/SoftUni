namespace p03._01.Heroes
{
    using System.Text;

    public class Item
    {
        private int strength;
        private int ability;
        private int intelligence;

        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public int Strength
        {
            get => this.strength;
            set => this.strength = value;
        }

        public int Ability
        {
            get => this.ability;
            set => this.ability = value;
        }

        public int Intelligence
        {
            get => this.intelligence;
            set => this.intelligence = value;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Item:")
                   .AppendLine($"    * Strength: {this.Strength}")
                   .AppendLine($"    * Ability: {this.Ability}")
                   .AppendLine($"    * Intelligence: {this.Intelligence}");

            return builder.ToString().TrimEnd();
        }
    }
}
