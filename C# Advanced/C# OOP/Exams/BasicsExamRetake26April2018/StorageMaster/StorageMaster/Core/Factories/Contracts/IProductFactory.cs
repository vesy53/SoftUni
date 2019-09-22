namespace StorageMaster.Core.Factories.Contracts
{
    using global::StorageMaster.Entities.Products;

    public interface IProductFactory
    {
        Product CreateProduct(string type, double price);
    }
}
