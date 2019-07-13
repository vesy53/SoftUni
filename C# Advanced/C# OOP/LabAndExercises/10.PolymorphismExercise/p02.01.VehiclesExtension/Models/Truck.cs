namespace p02._01.VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private const double AirConditionConsumption = 1.6;
        private const double KeepsFuel = 0.05;

        public Truck(
            double fuelQuantity, 
            double fuelConsumptionKM, 
            double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionKM, tankCapacity)
        {
            this.FuelConsumptionKM += AirConditionConsumption;
        }

        public override void Refuel(double amountFuel)
        {
            base.Refuel(amountFuel);

            this.FuelQuantity -= amountFuel * KeepsFuel;
        }
    }
}
