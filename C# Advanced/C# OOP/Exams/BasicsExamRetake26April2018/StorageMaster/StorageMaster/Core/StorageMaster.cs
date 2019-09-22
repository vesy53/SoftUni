namespace StorageMaster.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using global::StorageMaster.Common;
    using global::StorageMaster.Core.Contracts;
    using global::StorageMaster.Core.Factories;
    using global::StorageMaster.Core.Factories.Contracts;
    using global::StorageMaster.Entities.Contracts;
    using global::StorageMaster.Entities.Products;
    using global::StorageMaster.Entities.Storages;
    using global::StorageMaster.Entities.Vehicles;

    public class StorageMaster : IStorageMaster
    {
        private readonly IProductFactory productFactory;
        private readonly IStorageFactory storageFactory;
        private readonly IVehicleFactory vehicleFactory;

        private readonly List<Product> productPool;
        private readonly List<Storage> storageRegistry;
        private Vehicle currentVehicle;

        public StorageMaster()
        {
            this.productFactory = new ProductFactory();
            this.storageFactory = new StorageFactory();
            this.vehicleFactory = new VehicleFactory();

            this.productPool = new List<Product>();
            this.storageRegistry = new List<Storage>();
            this.currentVehicle = null;
        }

        public string AddProduct(string type, double price)
        {
            Product product = this.productFactory
                .CreateProduct(type, price);

            this.productPool.Add(product);

            return string.Format(
                ConstantMessages.CreatePool,
                type);
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = this.storageRegistry
                .FirstOrDefault(s => s.Name == storageName);

            var groupedProducts = storage
                .Products
                .GroupBy(p => p.GetType().Name);

            List<string> products = new List<string>();

            foreach (var groupedProduct in groupedProducts
                .OrderByDescending(g => g.ToList().Count)
                .ThenBy(g => g.Key))
            {
                products.Add($"{groupedProduct.Key} ({groupedProduct.Count()})");
            }

            double totalWeight = storage.Products.Sum(p => p.Weight);
            int storageCapacity = storage.Capacity;

            StringBuilder builder = new StringBuilder();

            builder.AppendLine(string.Format(
                ConstantMessages.StockStatus,
                totalWeight,
                storageCapacity,
                string.Join(", ", products)));

            List<string> vehiclesInGarage = new List<string>();

            foreach (Vehicle vehicle in storage.Garage)
            {
                if (vehicle == null)
                {
                    vehiclesInGarage.Add("empty");
                }
                else
                {
                    vehiclesInGarage.Add(vehicle.GetType().Name);
                }
            }

            builder.AppendLine(string.Format(
               ConstantMessages.GarageStatus,
               string.Join("|", vehiclesInGarage)));

            return builder.ToString().TrimEnd();
        }

        public string GetSummary()
        {
            StringBuilder builder = new StringBuilder();

            foreach (Storage storageInfo in this.storageRegistry
                .OrderByDescending(s => s.Products.Sum(p => p.Price)))
            {
                var totalMoney = storageInfo
                    .Products
                    .Sum(p => p.Price);

                builder.AppendLine(string.Format(
                    ConstantMessages.StorageName,
                    storageInfo.Name));

                builder.AppendLine(string.Format(
                    ConstantMessages.StorageWorth,
                    totalMoney));
            }

            return builder.ToString().TrimEnd();
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int countLoadedProducts = 0;
            
            foreach (string productName in productNames)
            {
                if (this.currentVehicle.IsFull)
                {
                    break;
                }

                Product product = this.productPool
                    .LastOrDefault(p => p.GetType().Name == productName);

                if (product is null)
                {
                    throw new InvalidOperationException(
                        string.Format(
                            ExceptionMessages.OutOfStock,
                            productName));
                }

                int index = this.productPool.LastIndexOf(product);
                this.productPool.RemoveAt(index);
                this.currentVehicle.LoadProduct(product);
                countLoadedProducts++;
            }

            return string.Format(
                ConstantMessages.LoadedProducts,
                countLoadedProducts,
                productNames.Count(),
                this.currentVehicle.GetType().Name);
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = this.storageFactory
                .CreateStorage(type, name);

            this.storageRegistry.Add(storage);

            return string.Format(
                ConstantMessages.RegisteredStorage,
                name);
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            IStorage storage = this.storageRegistry
                .FirstOrDefault(s => s.Name == storageName);

            Vehicle vehicle = storage.GetVehicle(garageSlot);

            this.currentVehicle = vehicle;

            return string.Format(
                ConstantMessages.SelectedVehicle,
                vehicle.GetType().Name);
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            Storage sourceStorage = this.storageRegistry
                .FirstOrDefault(s => s.Name == sourceName);
            Storage destinationStorage = this.storageRegistry
                .FirstOrDefault(s => s.Name == destinationName);

            if (sourceStorage is null ||
                destinationStorage is null)
            {
                string result = sourceStorage == null
                    ? "source"
                    : "destination";

                throw new InvalidOperationException(
                    string.Format(
                        ExceptionMessages.InvalidStorage,
                        result));
            }

            string vehicleType = sourceStorage
                .GetVehicle(sourceGarageSlot)
                .GetType()
                .Name;
            int destinationGarageSlot = sourceStorage
                .SendVehicleTo(sourceGarageSlot, destinationStorage);

            return string.Format(
                ConstantMessages.SentVehicleToDestination,
                vehicleType,
                destinationName,
                destinationGarageSlot);
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storageRegistry
                .FirstOrDefault(s => s.Name == storageName);

            Vehicle vehicle = storage.GetVehicle(garageSlot);

            int productsInVehicle = vehicle.Trunk.Count;
            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);

            return string.Format(
                ConstantMessages.UnloadedProducts,
                unloadedProductsCount,
                productsInVehicle,
                storageName);
        }
    }
}
