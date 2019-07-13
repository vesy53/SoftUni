namespace p02._01.VehiclesExtension.Models
{
    using Contracts;

    public class Bus : Vehicle, IDriveEmpty
    {
        private const double AirConditionConsumption = 1.4;

        public Bus(
            double fuelQuantity,
            double fuelConsumptionKM, 
            double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionKM, tankCapacity)
        {
            this.FuelConsumptionKM += AirConditionConsumption;
        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumptionKM -= AirConditionConsumption;

            return base.Drive(distance);
        }
    }
}
