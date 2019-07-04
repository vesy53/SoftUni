namespace NeedForSpeed.Vehicles.Cars
{
    public abstract class Car : Vehicle
    {
        private const double DefaultFuelConsumption = 3;

        protected Car(int horsePower, double fuel)
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
