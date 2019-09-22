namespace StorageMaster.Core.Factories
{
    using System;

    using global::StorageMaster.Common;
    using global::StorageMaster.Core.Factories.Contracts;
    using global::StorageMaster.Entities.Products;

    public class ProductFactory : IProductFactory
    {
        public Product CreateProduct(string type, double price)
        {
            Product product = null;

            switch (type)
            {
                case "Gpu":
                    product = new Gpu(price);
                    break;
                case "HardDrive":
                    product = new HardDrive(price);
                    break;
                case "Ram":
                    product = new Ram(price);
                    break;
                case "SolidStateDrive":
                    product = new SolidStateDrive(price);
                    break;
                default:
                    throw new InvalidOperationException(
                        string.Format(
                            ExceptionMessages.InvalidType,
                            "product"));
            }

            return product;
        }
    }
}
