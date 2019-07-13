namespace p02._01.VehiclesExtension.Models
{
    using Contracts;
    using System;

    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;

        protected Vehicle(
            double fuelQuantity, 
            double fuelConsumptionKM,
            double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionKM = fuelConsumptionKM;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            protected set
            {
                if (value > this.TankCapacity)
                {
                    value = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumptionKM { get; protected set; }

        public double TankCapacity { get; protected set; }

        public string Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumptionKM;

            if (neededFuel > this.FuelQuantity)
            {
                throw new ArgumentException(
                    $"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= neededFuel;

            string result = string.Format(
                $"{this.GetType().Name} travelled {distance} km");

            return result;
        }

        public virtual void Refuel(double amountFuel)
        {
            if (amountFuel <= 0)
            {
                throw new ArgumentException(
                    "Fuel must be a positive number");
            }

            double totalFuel = this.FuelQuantity + amountFuel;

            if (totalFuel > this.TankCapacity)
            {
                throw new ArgumentException(
                    $"Cannot fit {amountFuel} fuel in the tank");
            }

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
