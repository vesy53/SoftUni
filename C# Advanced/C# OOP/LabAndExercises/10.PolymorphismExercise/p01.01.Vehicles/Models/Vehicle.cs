namespace p01._01.Vehicles.Models
{
    using Contracts;

    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumptionKM)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionKM = fuelConsumptionKM;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumptionKM { get; protected set; }

        public string Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumptionKM;

            string result = string.Empty;

            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;

                result = 
                    $"{this.GetType().Name} travelled {distance} km";
            } 
            else
            {
                result = $"{this.GetType().Name} needs refueling";
            }

            return result;
        }

        public abstract void Refuel(double amountFuel);
    }
}
