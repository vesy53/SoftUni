namespace StorageMaster.Entities.Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using StorageMaster.Common;
    using StorageMaster.Entities.Contracts;
    using StorageMaster.Entities.Products;

    public abstract class Vehicle : IVehicle, IFullable
    {
        private readonly List<Product> trunk;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;

            this.trunk = new List<Product>();
        }

        public int Capacity { get; private set; }

        public IReadOnlyCollection<Product> Trunk => 
            this.trunk.AsReadOnly();

        public bool IsFull => 
            this.Trunk.Sum(t => t.Weight) >= this.Capacity;

        public bool IsEmpty => this.Trunk.Count == 0;

        public void LoadProduct(Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException(
                    ExceptionMessages.FullVehicle);
            }

            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException(
                    ExceptionMessages.EmptyVehicle);
            }

            Product lastProduct = this.Trunk.Last();

            this.trunk.Remove(lastProduct);

            return lastProduct;
        }
    }
}
