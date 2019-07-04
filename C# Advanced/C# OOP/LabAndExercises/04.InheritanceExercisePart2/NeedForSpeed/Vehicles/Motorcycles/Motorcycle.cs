namespace NeedForSpeed.Vehicles.Motorcycles
{
    public abstract class Motorcycle : Vehicle
    {
        protected Motorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption
            => base.FuelConsumption;

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
