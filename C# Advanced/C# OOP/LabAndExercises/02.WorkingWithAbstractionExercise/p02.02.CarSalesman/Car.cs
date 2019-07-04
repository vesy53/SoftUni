namespace p02._02.CarSalesman
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

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;

            this.weight = DefaultWeight;
            this.color = DefaultColor;
        }

        public Car(string model, Engine engine, int weight)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;

            this.color = DefaultColor;
        }

        public Car(string model, Engine engine, string color)
        {
            this.model = model;
            this.engine = engine;
            this.color = color;

            this.weight = DefaultWeight;
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:\n", this.model);
            sb.Append(this.engine.ToString());
            sb.AppendFormat(
                "{0}Weight: {1}\n", 
                Offset, 
                this.weight == -1 ? 
                    "n/a" : 
                    this.weight.ToString());
            sb.AppendFormat("{0}Color: {1}", Offset, this.color);

            return sb.ToString();
        }
    }
}
