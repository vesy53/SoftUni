namespace StorageMaster.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using global::StorageMaster.Core.Contracts;
    using global::StorageMaster.IO;
    using global::StorageMaster.IO.Contracts;

    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IStorageMaster storageMaster;

        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();
            this.storageMaster = new StorageMaster();
        }

        public void Run()
        {
            string input = this.reader.ReadLine();

            while (input.Equals("END") == false)
            {
                try
                {
                    string[] tokens = input
                        .Split(" ",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string command = tokens[0];

                    string storageName = string.Empty;
                    string result = string.Empty;

                    switch (command)
                    {
                        case "AddProduct":
                            string type = tokens[1];
                            double price = double.Parse(tokens[2]);

                            result = this.storageMaster
                                .AddProduct(type, price);
                            break;
                        case "RegisterStorage":
                            type = tokens[1];
                            string name = tokens[2];

                            result = this.storageMaster
                                .RegisterStorage(type, name);
                            break;
                        case "SelectVehicle":
                            storageName = tokens[1];
                            int garageSlot = int.Parse(tokens[2]);

                            result = this.storageMaster
                                .SelectVehicle(storageName, garageSlot);
                            break;
                        case "LoadVehicle":
                            List<string> productNames = tokens
                                .Skip(1)
                                .ToList();
                           
                            result = this.storageMaster
                                .LoadVehicle(productNames);
                            break;
                        case "SendVehicleTo":
                            string sourceName = tokens[1];
                            int sourceGarageSlot = int.Parse(tokens[2]);
                            string destinationName = tokens[3];

                            result = this.storageMaster
                                .SendVehicleTo(sourceName, sourceGarageSlot, destinationName);
                            break;
                        case "UnloadVehicle":
                            storageName = tokens[1];
                            garageSlot = int.Parse(tokens[2]);

                            result = this.storageMaster
                                .UnloadVehicle(storageName, garageSlot);
                            break;
                        case "GetStorageStatus":
                            storageName = tokens[1];

                            result = this.storageMaster
                                .GetStorageStatus(storageName);
                            break;
                    }

                    this.writer.WriteLine(result);
                }
                catch (InvalidOperationException ioe)
                {
                    this.writer.WriteLine($"Error: {ioe.Message}");
                }

                input = this.reader.ReadLine();
            }

            this.writer.WriteLine(this.storageMaster.GetSummary());
        }
    }
}
