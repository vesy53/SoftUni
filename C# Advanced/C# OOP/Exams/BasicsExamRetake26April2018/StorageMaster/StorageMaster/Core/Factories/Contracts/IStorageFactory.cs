namespace StorageMaster.Core.Factories.Contracts
{
    using global::StorageMaster.Entities.Storages;

    public interface IStorageFactory
    {
        Storage CreateStorage(string type, string name);
    }
}
