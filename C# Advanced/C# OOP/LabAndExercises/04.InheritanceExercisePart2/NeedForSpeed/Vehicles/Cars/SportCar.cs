namespace NeedForSpeed.Vehicles.Cars
{
    public class SportCar : Car
    {
        private const double DefaultFuelConsumption = 10;

        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption
            => DefaultFuelConsumption;

        public override void Drive(double kilometers)
        {
            base.Drive(kilometers);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
