namespace StorageMaster.Entities.Products
{
    public class Ram : Product
    {
        private const double InitialWeight = 0.1;

        public Ram(double price)
            : base(price, InitialWeight)
        {
        }
    }
}
