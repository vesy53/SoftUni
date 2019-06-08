namespace p07._01.SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string model = tokens[0];
                int fuelAmount = int.Parse(tokens[1]);
                double FuelConsumptionFor1km = double.Parse(tokens[2]);

                Car car = new Car(
                    model,
                    fuelAmount,
                    FuelConsumptionFor1km);

                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input.Equals("End") == false)
            {
                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string carModel = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);

                Car searchCar = cars
                    .Where(c => c.Model == carModel)
                    .FirstOrDefault();

                if (searchCar != null)
                {
                    searchCar.Drive(amountOfKm);
                }

                //or
                //int indexOfCurrentCar = cars
                //    .IndexOf(cars.Find(x => x.Model == carModel));
                //cars[indexOfCurrentCar].Drive(amountOfKm);

                input = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                string model = car.Model;
                double fuelAmount = car.FuelAmount;
                double traveledDistance = car.TraveledDistance;

                Console.WriteLine(
                    $"{model} {fuelAmount:F2} {traveledDistance}");
            }

            //or
            //cars
            //    .ForEach(c => Console.WriteLine(
            //        $"{c.Model} {c.FuelAmount:F2} {c.TraveledDistance}"));
        }
    }
}
