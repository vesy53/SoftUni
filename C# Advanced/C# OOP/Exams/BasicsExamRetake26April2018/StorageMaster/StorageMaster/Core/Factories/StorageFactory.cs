namespace StorageMaster.Core.Factories
{
    using System;

    using global::StorageMaster.Common;
    using global::StorageMaster.Core.Factories.Contracts;
    using global::StorageMaster.Entities.Storages;

    public class StorageFactory : IStorageFactory
    {
        public Storage CreateStorage(string type, string name)
        {
            Storage storage = null;

            switch (type)
            {
                case "AutomatedWarehouse":
                    storage = new AutomatedWarehouse(name);
                    break;
                case "DistributionCenter":
                    storage = new DistributionCenter(name);
                    break;
                case "Warehouse":
                    storage = new Warehouse(name);
                    break;
                default:
                    throw new InvalidOperationException(
                        string.Format(
                            ExceptionMessages.InvalidType,
                            "storage"));
            }

            return storage;
        }
    }
}
