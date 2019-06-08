namespace p06._01.AutoRepairAndService
{
    using System;
    using System.Collections.Generic;

    class AutoRepairAndService
    {
        static void Main(string[] args)
        {
            string[] vehicles = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);
            string[] commandArgs = Console.ReadLine()
                .Split("-");

            Queue<string> queue = new Queue<string>(vehicles);

            Stack<string> servedVehicle = new Stack<string>();

            while (commandArgs[0].Equals("End") == false)
            {
                string command = commandArgs[0];
                string result = string.Empty;

                switch (command)
                {
                    case "Service":
                        if (queue.Count != 0)
                        {
                            string currentVehicle = queue.Peek();

                            queue.Dequeue();
                            servedVehicle.Push(currentVehicle);

                            result = $"Vehicle {currentVehicle} got served.";
                        }
                        break;
                    case "CarInfo":
                        string searchVehicle = commandArgs[1];

                        if (queue.Contains(searchVehicle))
                        {
                            result = "Still waiting for service.";
                        }
                        else
                        {
                            result = "Served.";
                        }
                        break;
                    case "History":
                        result = string.Join(", ", servedVehicle);
                        break;
                }

                if (result != string.Empty)
                {
                    Console.WriteLine(result);
                }

                commandArgs = Console.ReadLine()
                    .Split("-");
            }

            if (queue.Count != 0)
            {
                Console.WriteLine(
                    $"Vehicles for service: {string.Join(", ", queue)}");
            }

            if (servedVehicle.Count != 0)
            {
                Console.WriteLine(
                    $"Served vehicles: {string.Join(", ", servedVehicle)}");
            }
        }
    }
}
