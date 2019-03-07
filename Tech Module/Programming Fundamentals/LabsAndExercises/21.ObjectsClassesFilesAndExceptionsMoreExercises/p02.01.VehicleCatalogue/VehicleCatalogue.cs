namespace p02._01.VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class VehicleCatalogue
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
                    Catalogue newCar = new Catalogue();

                    newCar.Type = type;
                    newCar.Model = model;
                    newCar.Color = color;
                    newCar.Horsepower = horsepower;
                 
                    cars.Add(newCar);
                }
                else if (type.Equals("truck"))
                {
                    Catalogue newTruck = new Catalogue();

                    newTruck.Type = type;
                    newTruck.Model = model;
                    newTruck.Color = color;
                    newTruck.Horsepower = horsepower;

                    trucks.Add(newTruck);
                }

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command.Equals("Close the Catalogue") == false)
            {               
                foreach (var car in cars)
                {
                    if (car.Model == command)
                    {
                         Console.WriteLine($"Type: Car");
                         Console.WriteLine($"Model: {car.Model}");
                         Console.WriteLine($"Color: {car.Color}");
                         Console.WriteLine($"Horsepower: {car.Horsepower}");
                    }
                }               

                foreach (var truck in trucks
                    .OrderBy(x => x.Model))
                {
                    if (truck.Model == command)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.Horsepower}");
                    }
                }

                command = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                var averageCarsPower = cars
                    .Select(x => x.Horsepower)
                    .Average();

                Console.WriteLine(
                    $"Cars have average horsepower of: {averageCarsPower:F2}.");
            }
            else
            {
                Console.WriteLine(
                    $"Cars have average horsepower of: 0.00.");
            }

            if (trucks.Count > 0)
            {
                var averageTrucksPower = trucks
                    .Select(x => x.Horsepower)
                    .Average();

                Console.WriteLine(
                    $"Trucks have average horsepower of: {averageTrucksPower:F2}.");
            }
            else
            {
                Console.WriteLine(
                    $"Trucks have average horsepower of: 0.00.");
            }
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
