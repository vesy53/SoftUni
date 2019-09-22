namespace StorageMaster.Entities.Products
{
    using System;

    using StorageMaster.Common;
    using StorageMaster.Entities.Contracts;

    public abstract class Product : IProduct
    {
        private double price;

        protected Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException(
                        ExceptionMessages.InvalidPrice);
                }

                this.price = value;
            }
        }

        public double Weight { get; private set; }
    }
}
