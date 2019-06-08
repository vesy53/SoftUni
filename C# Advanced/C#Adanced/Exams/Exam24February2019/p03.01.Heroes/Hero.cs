namespace p03._01.Heroes
{
    using System.Text;

    public class Hero
    {
        private string name;
        private int level;
        private Item item;

        public Hero()
        {

        }

        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int Level
        {
            get => this.level;
            set => this.level = value;
        }

        public Item Item
        {
            get => this.item;
            set => this.item = value;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"Hero: {this.Name} – {this.Level}lvl")
                .AppendLine($"{this.Item}");

            return builder.ToString().TrimEnd();
        }
    }
}
