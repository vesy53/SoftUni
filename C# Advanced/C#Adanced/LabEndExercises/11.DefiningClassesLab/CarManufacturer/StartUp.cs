namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
}
