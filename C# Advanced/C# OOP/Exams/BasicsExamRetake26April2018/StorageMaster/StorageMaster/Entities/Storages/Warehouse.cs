namespace StorageMaster.Entities.Storages
{
    using StorageMaster.Entities.Vehicles;

    public class Warehouse : Storage
    {
        private const int InitialCapacity = 10;
        private const int InitialGarageSlots = 10;

        private static Vehicle[] InitialVehicles = new Vehicle[]
        {
            new Semi(),
            new Semi(),
            new Semi()
        };

        public Warehouse(string name)
            : base(name, InitialCapacity, InitialGarageSlots, InitialVehicles)
        {
        }
    }
}
