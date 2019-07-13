namespace p02._01.VehiclesExtension.Models.Contracts
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double FuelConsumptionKM  { get; }

        double TankCapacity  { get; }

        string Drive(double distance);

        void Refuel(double amountFuel);
    }
}
