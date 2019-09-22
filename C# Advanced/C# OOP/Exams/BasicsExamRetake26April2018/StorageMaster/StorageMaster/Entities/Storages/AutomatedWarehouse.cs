namespace StorageMaster.Entities.Storages
{
    using StorageMaster.Entities.Vehicles;

    public class AutomatedWarehouse : Storage
    {
        private const int InitialCapacity = 1;
        private const int InitialGarageSlots = 2;

        private static Vehicle[] InitialVehicles = new Vehicle[]
        { 
            new Truck()
        };

        public AutomatedWarehouse(string name) 
            : base(name, InitialCapacity, InitialGarageSlots, InitialVehicles)
        {
        }
    }
}
