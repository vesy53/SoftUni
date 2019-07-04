namespace p02._02.CarSalesman
{
    using System.Text;

    public class Engine
    {
        private const string Offset = "  ";
        private const int DefaultDisplacement = -1;
        private const string DefaultEfficiency = "n/a";

        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.power = power;

            this.displacement = DefaultDisplacement;
            this.efficiency = DefaultEfficiency;
        }

        public Engine(string model, int power, int displacement)
        {
            this.Model = model;
            this.power = power;
            this.displacement = displacement;

            this.efficiency = DefaultEfficiency;
        }

        public Engine(string model, int power, string efficiency)
        {
            this.Model = model;
            this.power = power;
            this.efficiency = efficiency;

            this.displacement = DefaultDisplacement;
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}:\n", Offset, this.Model);
            sb.AppendFormat("{0}{0}Power: {1}\n", Offset, this.power);
            sb.AppendFormat(
                "{0}{0}Displacement: {1}\n", 
                Offset, 
                this.displacement == -1 ? 
                    "n/a" : 
                    this.displacement.ToString());
            sb.AppendFormat("{0}{0}Efficiency: {1}\n", Offset, this.efficiency);

            return sb.ToString();
        }
    }
}
