namespace p02._01.CarsSalesman
{
    using System.Text;

    public class Car
    {
        private const string Offset = "  ";
        private const int DefaultWeight = -1;
        private const string DefaultColor = "n/a";

        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car()
        {
            this.Weight = DefaultWeight;
            this.Color = DefaultColor;
        }

        public Car(string model, Engine engine)
            : this()
        {
            this.Model = model;
            this.Engine = engine;
        }

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public Engine Engine
        {
            get => this.engine;
            set => this.engine = value;
        }

        public int Weight
        {
            get => this.weight;
            set => this.weight = value;
        }

        public string Color
        {
            get => this.color;
            set => this.color = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}:\n", this.Model);
            sb.Append(this.Engine.ToString());
            sb.AppendFormat(
                "{0}Weight: {1}\n", 
                Offset, 
                this.Weight == -1 ? 
                    "n/a" : 
                    this.Weight.ToString());
            sb.AppendFormat("{0}Color: {1}", Offset, this.Color);

            return sb.ToString();
        }
    }
}
