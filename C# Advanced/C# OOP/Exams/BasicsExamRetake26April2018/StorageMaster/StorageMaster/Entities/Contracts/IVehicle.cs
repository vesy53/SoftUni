namespace StorageMaster.Entities.Contracts
{
    using System.Collections.Generic;

    using StorageMaster.Entities.Products;

    public interface IVehicle
    {
        int Capacity { get; }

        IReadOnlyCollection<Product> Trunk { get; }

        bool IsEmpty { get; }

        void LoadProduct(Product product);

        Product Unload();
    }
}
