namespace StorageMaster.Core.Factories.Contracts
{
    using global::StorageMaster.Entities.Vehicles;

    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(string type);
    }
}
