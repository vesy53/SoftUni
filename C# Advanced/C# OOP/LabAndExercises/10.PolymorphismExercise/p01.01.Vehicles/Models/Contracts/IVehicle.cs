namespace p01._01.Vehicles.Models.Contracts
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double FuelConsumptionKM  { get; }

        string Drive(double distance);

        void Refuel(double amountFuel);
    }
}
