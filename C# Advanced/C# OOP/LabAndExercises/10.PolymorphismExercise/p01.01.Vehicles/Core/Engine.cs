namespace p01._01.Vehicles.Core
{
    using System;

    using IO.Contracts;
    using p01._01.Vehicles.Models;
    using p01._01.Vehicles.Models.Contracts;

    public class Engine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string[] inputCar = reader
                .ConsoleReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);
            string[] inputTruck = reader
                .ConsoleReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(inputCar[1]);
            double carLiters = double.Parse(inputCar[2]);

            double truckFuelQuantity = double.Parse(inputTruck[1]);
            double truckLiters = double.Parse(inputTruck[2]);

            IVehicle car = new Car(carFuelQuantity, carLiters);
            IVehicle truck = new Truck(truckFuelQuantity, truckLiters);

            int number = int.Parse(reader.ConsoleReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] tokens = reader
                    .ConsoleReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];
                string typeVehicle = tokens[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(tokens[2]);

                    string result = string.Empty;

                    if (typeVehicle == "Car")
                    {
                        result = car.Drive(distance);
                    }
                    else if (typeVehicle == "Truck")
                    {
                        result = truck.Drive(distance);
                    }

                    Console.WriteLine(result);
                }
                else if (command == "Refuel")
                {
                    double amountFuel = double.Parse(tokens[2]);

                    if (typeVehicle == "Car")
                    {
                        car.Refuel(amountFuel);
                    }
                    else if (typeVehicle == "Truck")
                    {
                        truck.Refuel(amountFuel);
                    }
                }
            }

            writer.ConsoleWriteLine(car.ToString());
            writer.ConsoleWriteLine(truck.ToString());
        }
    }
}
