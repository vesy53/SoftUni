namespace p08._01.RawData
{
    public class Car
    {
        private const int DefaultLength = 4;
    
        private string model;
        private Engine engine;
        private Cargo cargo;

        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = new Tire[DefaultLength];
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tires { get; set; }
    }
}
