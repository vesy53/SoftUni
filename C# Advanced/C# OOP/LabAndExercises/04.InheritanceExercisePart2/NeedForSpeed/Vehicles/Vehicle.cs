namespace NeedForSpeed.Vehicles
{
    public abstract class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        protected Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual double FuelConsumption
            => DefaultFuelConsumption;

        public int HorsePower { get; private set; }

        public double Fuel { get; private set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= this.FuelConsumption * kilometers;
        }

        public override string ToString()
        {
            string result = string.Format(
                $"Horse Power: {this.HorsePower} Fuel: {this.Fuel}");

            return result;
        }
    }
}
