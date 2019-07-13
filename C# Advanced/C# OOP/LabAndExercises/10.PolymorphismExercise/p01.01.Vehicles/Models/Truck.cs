namespace p01._01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double AirConditionConsumption = 1.6;
        private const double KeepsFuel = 0.95;

        public Truck(double fuelQuantity, double fuelConsumptionKM)
            : base(fuelQuantity, fuelConsumptionKM)
        {
            this.FuelConsumptionKM += AirConditionConsumption;
        }

        public override void Refuel(double amountFuel)
        {
            amountFuel *= KeepsFuel;

            this.FuelQuantity += amountFuel;
        }

        public override string ToString()
        {
            string result = string.Format(
                $"{this.GetType().Name}: {this.FuelQuantity:F2}");

            return result;
        }
    }
}
