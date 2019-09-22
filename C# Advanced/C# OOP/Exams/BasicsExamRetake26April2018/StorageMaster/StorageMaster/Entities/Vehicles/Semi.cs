namespace StorageMaster.Entities.Vehicles
{
    public class Semi : Vehicle
    {
        private const int InitialCapacity = 10;

        public Semi()
            : base(InitialCapacity)
        {
        }
    }
}
