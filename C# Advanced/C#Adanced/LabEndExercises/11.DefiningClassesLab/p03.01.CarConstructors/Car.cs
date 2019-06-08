namespace p03._01.CarConstructors
{
    using System;
    using System.Text;

    public class Car
    {
        private const string MakeDefault = "VW";
        private const string ModelDefault = "Golf";
        private const int YearDefault = 2025;
        private const double FuelQuantityDefault = 200;
        private const double FuelConsumptionDefault = 10;

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {
            this.Make = MakeDefault;
            this.Model = ModelDefault;
            this.Year = YearDefault;
            this.FuelQuantity = FuelQuantityDefault;
            this.FuelConsumption = FuelConsumptionDefault;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

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
