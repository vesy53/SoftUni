namespace StorageMaster.Entities.Storages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using StorageMaster.Common;
    using StorageMaster.Entities.Contracts;
    using StorageMaster.Entities.Products;
    using StorageMaster.Entities.Vehicles;

    public abstract class Storage : IStorage, IFullable
    {
        private readonly Vehicle[] garage;
        private readonly List<Product> products;

        protected Storage(
            string name, 
            int capacity, 
            int garageSlots,
            IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.garage = new Vehicle[garageSlots];
            this.products = new List<Product>();

            vehicles.ToArray().CopyTo(this.garage, 0);
            //FullTheGarageWithInitialVehicles(vehicles);
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        public bool IsFull => 
            this.Products.Sum(p => p.Weight) >= this.Capacity;
        
        public IReadOnlyCollection<Vehicle> Garage => 
            Array.AsReadOnly(this.garage);

        public IReadOnlyCollection<Product> Products => 
            this.products.AsReadOnly();

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException(
                    ExceptionMessages.InvalidGarageSlot);
            }

            Vehicle vehicle = this.garage[garageSlot];

            if (vehicle is null)
            {
                throw new InvalidOperationException(
                   ExceptionMessages.EmptyGarageSlot);
            }

            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);

            bool isFreeSlotGarageDelivery = deliveryLocation
                .Garage
                .Any(g => g == null);

            if (!isFreeSlotGarageDelivery)
            {
                throw new InvalidOperationException(
                    ExceptionMessages.NoRoomInGarage);
            }

            int vehicleTransferred = 0;
            
            for (int i = 0; i < deliveryLocation.garage.Length; i++)
            {
                if (deliveryLocation.garage[i] == null)
                {
                    deliveryLocation.garage[i] = vehicle;
                    this.garage[garageSlot] = null;
                    vehicleTransferred = i;
                    break;
                }
            }

            return vehicleTransferred;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException(
                    ExceptionMessages.StorageIsFull);
            }

            Vehicle vehicle = this.GetVehicle(garageSlot);

            int countUnloadedProducts = 0;

            while (!this.IsFull &&
                !vehicle.IsEmpty)
            {
                Product unload = vehicle.Unload();
                this.products.Add(unload);
                countUnloadedProducts++;
            }

            return countUnloadedProducts;
        }

        /*private void FullTheGarageWithInitialVehicles(
            IEnumerable<Vehicle> vehicles)
        {
            int index = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                this.garage[index++] = vehicle;
            }
        }*/
    }
}
