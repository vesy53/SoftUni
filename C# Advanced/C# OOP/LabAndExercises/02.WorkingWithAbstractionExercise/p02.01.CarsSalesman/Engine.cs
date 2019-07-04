namespace p02._01.CarsSalesman
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

        public Engine()
        {
            this.Displacement = DefaultDisplacement;
            this.Efficiency = DefaultEfficiency;
        }

        public Engine(string model, int power)
            : this()
        {
            this.Model = model;
            this.Power = power;
        }

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public int Power
        {
            get => this.power;
            set => this.power = value;
        }

        public int Displacement
        {
            get => this.displacement;
            set => this.displacement = value;
        }

        public string Efficiency
        {
            get => this.efficiency;
            set => this.efficiency = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}:\n", Offset, this.Model);
            sb.AppendFormat("{0}{0}Power: {1}\n", Offset, this.Power);
            sb.AppendFormat(
                "{0}{0}Displacement: {1}\n", 
                Offset, 
                this.Displacement == -1 ? 
                    "n/a" : 
                    this.Displacement.ToString());
            sb.AppendFormat("{0}{0}Efficiency: {1}\n", Offset, this.Efficiency);

            return sb.ToString();
        }
    }
}
