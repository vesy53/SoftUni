namespace StorageMaster.Entities.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using StorageMaster.Entities.Products;
    using StorageMaster.Entities.Storages;
    using StorageMaster.Entities.Vehicles;

    public interface IStorage
    {
        string Name { get; }

        int Capacity { get; }

        int GarageSlots { get; }

        IReadOnlyCollection<Vehicle> Garage { get; }

        IReadOnlyCollection<Product> Products { get; }

        Vehicle GetVehicle(int garageSlot);

        int SendVehicleTo(int garageSlot, Storage deliveryLocation);

        int UnloadVehicle(int garageSlot);
    }
}
