namespace StorageMaster.Core.Factories
{
    using System;

    using global::StorageMaster.Common;
    using global::StorageMaster.Core.Factories.Contracts;
    using global::StorageMaster.Entities.Vehicles;

    public class VehicleFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle(string type)
        {
            Vehicle vehicle = null;

            switch (type)
            {
                case "Semi":
                    vehicle = new Semi();
                    break;
                case "Truck":
                    vehicle = new Truck();
                    break;
                case "Van":
                    vehicle = new Van();
                    break;
                default:
                    throw new InvalidOperationException(
                        string.Format(
                            ExceptionMessages.InvalidType,
                            "vehicle"));
            }

            return vehicle;
        }
    }
}
