namespace p01._01.RawData
{
    public class Car
    {
        private const int DefaultLength = 4;

        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;

            this.Tires = new Tire[DefaultLength];
        }

        public string Model
        {
            get => this.model;
            private set => this.model = value;
        }

        public Engine Engine
        {
            get => this.engine;
            private set => this.engine = value;
        }

        public Cargo Cargo
        {
            get => this.cargo;
            private set => this.cargo = value;
        }

        public Tire[] Tires
        {
            get => this.tires;
            private set => this.tires = value;
        }
    }
}
