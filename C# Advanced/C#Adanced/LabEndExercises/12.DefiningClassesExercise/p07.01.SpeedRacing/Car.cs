namespace p07._01.SpeedRacing
{
    using System;

    public class Car
    {
        private const double DefaultTraveledDistance = 0;

        private string model;
        private double fuelAmount;
        private double fuelConsumptionFor1km;
        private double traveledDistance;

        public Car(
            string model, 
            int fuelAmount, 
            double fuelConsumptionFor1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1km = fuelConsumptionFor1km;
            this.TraveledDistance = DefaultTraveledDistance;
        }

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public double FuelAmount
        {
            get => this.fuelAmount;
            set => this.fuelAmount = value;
        }

        public double FuelConsumptionFor1km
        {
            get => this.fuelConsumptionFor1km;
            set => this.fuelConsumptionFor1km = value;
        }

        public double TraveledDistance
        {
            get => this.traveledDistance;
            set => this.traveledDistance = value;
        }

        public void Drive(double amountOfKm)
        {
            double totalKm = this.FuelConsumptionFor1km * amountOfKm;

            if (this.FuelAmount >= totalKm)
            {
                this.FuelAmount -= totalKm;
                this.TraveledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
