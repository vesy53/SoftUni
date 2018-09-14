namespace p02._01.VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class VehicleCatalogue3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Catalogue> cars = new List<Catalogue>();
            List<Catalogue> trucks = new List<Catalogue>();

            while (input.Equals("End") == false)
            {
                List<string> inputTokens = input
                    .Split(' ')
                    .ToList();

                string type = inputTokens[0].ToLower();
                string model = inputTokens[1];
                string color = inputTokens[2];
                int horsepower = int.Parse(inputTokens[3]);

                if (type.Equals("car"))
                {
                    Catalogue newCar = CreateCatalogue(
                        type,
                        model, 
                        color, 
                        horsepower);

                    cars.Add(newCar);
                }
                else if (type.Equals("truck"))
                {
                    Catalogue newTruck = CreateCatalogue(
                        type,
                        model,
                        color,
                        horsepower);

                    trucks.Add(newTruck);
                }

                input = Console.ReadLine();
            }

            PrintVehiclesData(cars, trucks);
            PrintAverageCars(cars);
            PrintAverageTrucks(trucks);
        }

        static void PrintAverageTrucks(List<Catalogue> trucks)
        {
            var listTruck = trucks
                .Where(x => x.Type == "truck")
                .ToList();

            var averageTruck = listTruck.Count > 0 ?
                listTruck.Select(x => x.Horsepower)
                .Average() :
                0.0;

            Console.WriteLine(
                $"Trucks have average horsepower of: {averageTruck:F2}.");

        }

        static void PrintAverageCars(List<Catalogue> cars)
        {
            var listCar = cars
                .Where(x => x.Type == "car")
                .ToList();

            var averageCar = cars.Count > 0 ?
                listCar
                .Select(x => x.Horsepower)
                .Average() :
                0.0;

            Console.WriteLine(
                $"Cars have average horsepower of: {averageCar:F2}.");
        }

        static void PrintVehiclesData(List<Catalogue> cars, List<Catalogue> trucks)
        {
            string command = Console.ReadLine();

            while (command.Equals("Close the Catalogue") == false)
            {
                foreach (var car in cars)
                {
                    if (car.Model == command)
                    {
                        Console.WriteLine($"Type: Car");

                        PrintData(
                            car.Model, 
                            car.Color,
                            car.Horsepower);
                    }
                }

                foreach (var truck in trucks
                    .OrderBy(x => x.Model))
                {
                    if (truck.Model == command)
                    {
                        Console.WriteLine($"Type: Truck");

                        PrintData(
                            truck.Model,
                            truck.Color,
                            truck.Horsepower);
                    }
                }

                command = Console.ReadLine();
            }

        }

        static void PrintData(string model, string color, int horsepower)
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Horsepower: {horsepower}");
        }

        static Catalogue CreateCatalogue(string type, string model, string color, int horsepower)
        {
            Catalogue newCar = new Catalogue();

            newCar.Type = type;
            newCar.Model = model;
            newCar.Color = color;
            newCar.Horsepower = horsepower;

            return newCar;
        }
    }

    class Catalogue
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }
}
