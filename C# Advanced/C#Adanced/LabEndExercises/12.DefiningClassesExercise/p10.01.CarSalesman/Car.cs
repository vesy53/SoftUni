namespace p10._01.CarSalesman
{
    using System.Text;

    public class Car
    {
        private const string DefaultValue = "n/a";

        public Car(
            string model,
            Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = DefaultValue;
            this.Color = DefaultValue;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public string Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"{this.Model}:")
                .AppendLine($"{this.Engine}")
                .AppendLine($"  Weight: {this.Weight}")
                .AppendLine($"  Color: {this.Color}");

            return builder.ToString().TrimEnd();
        }
    }
}
