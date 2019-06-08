namespace p02._01.CarManufacturer
{
    using System;
    using System.Text;

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make
        {
            get
            {
                return this.make;
            }

            set
            {
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }

            set
            {
                this.year = value;
            }
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            set
            {
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }

            set
            {
                this.fuelConsumption = value;
            }
        }

        public void Drive(double distance)
        {
            double result = distance * this.fuelConsumption / 100;

            if (result >= this.fuelQuantity)
            {
                Console.WriteLine(
                    "Not enough fuel to perform this trip!");
            }
            else
            {
                this.fuelQuantity -= this.fuelConsumption / 100 * distance;
            }
        }

        public string WhoAmI()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Make: {this.Make}")
                   .AppendLine($"Model: {this.Model}")
                   .AppendLine($"Year: {this.Year}")
                   .AppendLine($"Fuel: {this.FuelQuantity:F2}L");

            return builder.ToString().TrimEnd();
        }
    }
}
