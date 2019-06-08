namespace p05._01.SpecialCars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (input.Equals("No more tires") == false)
            {
                string[] tiresStr = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                Tire[] arrayTires = new Tire[4]
                {
                        new Tire(int.Parse(tiresStr[0]),double.Parse(tiresStr[1])),
                        new Tire(int.Parse(tiresStr[2]),double.Parse(tiresStr[3])),
                        new Tire(int.Parse(tiresStr[4]),double.Parse(tiresStr[5])),
                        new Tire(int.Parse(tiresStr[6]),double.Parse(tiresStr[7])),
                };

                tires.Add(arrayTires);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input.Equals("Engines done") == false)
            {
                string[] enginesStr = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                int horsePower = int.Parse(enginesStr[0]);
                double cubicCapacity = double.Parse(enginesStr[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);

                engines.Add(engine);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input.Equals("Show special") == false)
            {
                string[] carsStr = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string make = carsStr[0];
                string model = carsStr[1];
                int year = int.Parse(carsStr[2]);
                double fuelQuantity = double.Parse(carsStr[3]);
                double fuelConsumption = double.Parse(carsStr[4]);
                int engineIndex = int.Parse(carsStr[5]);
                int tiresIndex = int.Parse(carsStr[6]);

                Car car = new Car(
                    make,
                    model,
                    year,
                    fuelQuantity,
                    fuelConsumption,
                    engines[engineIndex],
                    tires[tiresIndex]);

                bool isSpecialCar = IsSpecialCar(car);

                if (isSpecialCar)
                {
                    int distance = 20;

                    car.Drive(distance);
                    cars.Add(car);
                }

                input = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.WhoAmI());
            }

        }

        private static bool IsSpecialCar(Car car)
        {
            bool isSpecialCar = car.Year >= 2017 &&
                   car.Engine.HorsePower >= 330 &&
                   car.Tires.Select(x => x.Pressure).Sum() >= 9 &&
                   car.Tires.Select(x => x.Pressure).Sum() <= 10;

            if (isSpecialCar)
            {
                return true;
            }

            return false;
        }
    }

    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }

            set
            {
                this.horsePower = value;
            }
        }

        public double CubicCapacity
        {
            get
            {
                return this.cubicCapacity;
            }

            set
            {
                this.cubicCapacity = value;
            }
        }
    }

    public class Tire
    {
        private int year;
        private double pressure;

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
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

        public double Pressure
        {
            get
            {
                return this.pressure;
            }

            set
            {
                this.pressure = value;
            }
        }
    }

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
        private Engine engine;
        private Tire[] tires;

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

        public Car(
            string make,
            string model,
            int year,
            double fuelQuantity,
            double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(
            string make,
            string model,
            int year,
            double fuelQuantity,
            double fuelConsumption,
            Engine engine,
            Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
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

        public Engine Engine
        {
            get
            {
                return this.engine;
            }

            set
            {
                this.engine = value;
            }
        }

        public Tire[] Tires
        {
            get
            {
                return this.tires;
            }

            set
            {
                this.tires = value;
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
                   .AppendLine($"HorsePowers: {this.Engine.HorsePower}")
                   .AppendLine($"FuelQuantity: {this.FuelQuantity}");

            return builder.ToString().TrimEnd();
        }
    }

}
