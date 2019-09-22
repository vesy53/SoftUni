namespace StorageMaster.Entities.Products
{
    public class HardDrive : Product
    {
        private const double InitialWeight = 1;

        public HardDrive(double price)
            : base(price, InitialWeight)
        {
        }
    }
}
