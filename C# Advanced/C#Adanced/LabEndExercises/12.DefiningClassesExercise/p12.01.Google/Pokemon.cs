using System.Text;

namespace p12._01.Google
{
    public class Pokemon
    {
        private string name;
        private string type;

        public Pokemon(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{this.Name} {this.Type}");

            return builder.ToString().TrimEnd();
        }
    }
}
