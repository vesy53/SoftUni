namespace p10._01.CarSalesman
{
    using System.Text;

    public class Engine
    {
        private const string DefaultValue = "n/a";

        public Engine(
            string model,
            int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = DefaultValue;
            this.Efficiency = DefaultValue;
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public string Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"  {this.Model}:")
                .AppendLine($"    Power: {this.Power}")
                .AppendLine($"    Displacement: {this.Displacement}")
                .AppendLine($"    Efficiency: {this.Efficiency}");

            return builder.ToString().TrimEnd();
        }
    }
}
