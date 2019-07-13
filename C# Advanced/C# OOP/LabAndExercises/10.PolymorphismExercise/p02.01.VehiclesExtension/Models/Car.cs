namespace p02._01.VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private const double AirConditionConsumption = 0.9;

        public Car(
            double fuelQuantity,
            double fuelConsumptionKM,
            double tankCapacity)
            : base(fuelQuantity, fuelConsumptionKM, tankCapacity)
        {
            this.FuelConsumptionKM += AirConditionConsumption;
        }
    }
}
