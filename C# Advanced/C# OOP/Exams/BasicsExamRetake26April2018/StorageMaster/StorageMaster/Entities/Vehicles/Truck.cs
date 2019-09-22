namespace StorageMaster.Entities.Vehicles
{
    public class Truck : Vehicle
    {
        private const int InitialCapacity = 5;

        public Truck()
            : base(InitialCapacity)
        {
        }
    }
}
