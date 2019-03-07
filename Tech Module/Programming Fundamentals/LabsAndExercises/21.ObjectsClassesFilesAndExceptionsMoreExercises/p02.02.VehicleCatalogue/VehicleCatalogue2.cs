namespace p02._02.VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class VehicleCatalogue2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Vehicle> catalog = new List<Vehicle>();

            while (input.Equals("End") == false)
            {
                List<string> inputTokens = input
                    .Split(' ')
                    .ToList();

                bool isCar = inputTokens[0]
                    .ToLower() == "car";
                string model = inputTokens[1];
                string color = inputTokens[2];
                int horsepower = int.Parse(inputTokens[3]);

                if (isCar)
                {
                    Vehicle newVehicle = new Vehicle
                    (
                        isCar,
                        model,
                        color,
                        horsepower
                    );

                    catalog.Add(newVehicle);
                }
                else
                {
                    Vehicle newVehicle = new Vehicle
                    (
                        isCar,
                        model,
                        color,
                        horsepower
                    );

                    catalog.Add(newVehicle);
                }

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command.Equals("Close the Catalogue") == false)
            {
                Console.WriteLine(
                    catalog.First(x => x.Model == command));

                command = Console.ReadLine();
            }

            var listCar = catalog
                .Where(x => x.IsCar == true)
                .ToList();

            var averageCar = listCar.Count > 0 ?
                listCar
                .Select(x => x.Horsepower)
                .Average() :
                0.0;

            Console.WriteLine(
                $"Cars have average horsepower of: {averageCar:F2}.");

            var listTruck = catalog
                .Where(x => x.IsCar == false)
                .ToList();

            var averageTruck = listTruck.Count > 0 ?
                listTruck.Select(x => x.Horsepower)
                .Average() :
                0.0;

            Console.WriteLine(
                $"Trucks have average horsepower of: {averageTruck:F2}.");
        }
    }

    class Vehicle
    {
        public bool IsCar { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }

        public Vehicle(
            bool isCar,
            string model,
            string color,
            int horsepower)
        {
            this.IsCar = isCar;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public override string ToString()
        {
            string vehicleType = IsCar ? "Car" : "Truck";
            string result = $"Type: {vehicleType}\r\n";
            result += $"Model: {Model}\r\n";
            result += $"Color: {Color}\r\n";
            result += $"Horsepower: {Horsepower}";

            return result;
        }
    }
}
