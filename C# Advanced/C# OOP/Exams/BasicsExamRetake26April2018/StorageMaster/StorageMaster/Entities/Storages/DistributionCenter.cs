namespace StorageMaster.Entities.Storages
{
    using StorageMaster.Entities.Vehicles;

    public class DistributionCenter : Storage
    {
        private const int InitialCapacity = 2;
        private const int InitialGarageSlots = 5;

        private static Vehicle[] InitialVehicles = new Vehicle[]
        {
            new Van(),
            new Van(),
            new Van()
        };

        public DistributionCenter(string name) 
            : base(name, InitialCapacity, InitialGarageSlots, InitialVehicles)
        {
        }
    }
}
