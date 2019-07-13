namespace p02._01.VehiclesExtension.Core
{
    using System;

    using IO.Contracts;
    using p02._01.VehiclesExtension.Models;
    using p02._01.VehiclesExtension.Models.Contracts;

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
            string[] inputBus = reader
                .ConsoleReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(inputCar[1]);
            double carLiters = double.Parse(inputCar[2]);
            double carTankCapacity = double.Parse(inputCar[3]);

            double truckFuelQuantity = double.Parse(inputTruck[1]);
            double truckLiters = double.Parse(inputTruck[2]);
            double truckTankCapacity = double.Parse(inputTruck[3]);

            double busFuelQuantity = double.Parse(inputBus[1]);
            double busLiters = double.Parse(inputBus[2]);
            double busTankCapacity = double.Parse(inputBus[3]);

            IVehicle car = new Car(carFuelQuantity, carLiters, carTankCapacity);
            IVehicle truck = new Truck(truckFuelQuantity, truckLiters, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busLiters, busTankCapacity);

            int number = int.Parse(reader.ConsoleReadLine());

            for (int i = 0; i < number; i++)
            {
                try
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
                        else if (typeVehicle == "Bus")
                        {
                            result = bus.Drive(distance);
                        }

                        writer.ConsoleWriteLine(result);
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
                        else if (typeVehicle == "Bus")
                        {
                            bus.Refuel(amountFuel);
                        }
                    }
                    else if (command == "DriveEmpty" &&
                        typeVehicle == "Bus")
                    {
                        double distance = double.Parse(tokens[2]);

                        string result = bus.DriveEmpty(distance);

                        writer.ConsoleWriteLine(result);
                    }
                }
                catch (ArgumentException ae)
                {
                    writer.ConsoleWriteLine(ae.Message);
                }
            }

            writer.ConsoleWriteLine(car.ToString());
            writer.ConsoleWriteLine(truck.ToString());
            writer.ConsoleWriteLine(bus.ToString());
        }
    }
}
