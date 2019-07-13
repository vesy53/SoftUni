namespace p01._01.Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double AirConditionConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionKM)
            : base(fuelQuantity, fuelConsumptionKM)
        {
            this.FuelConsumptionKM += AirConditionConsumption;
        }

        public override void Refuel(double amountFuel)
        {
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
