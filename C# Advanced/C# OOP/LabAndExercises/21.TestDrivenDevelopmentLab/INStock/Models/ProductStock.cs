namespace INStock.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using INStock.Contracts;

    public class ProductStock : IProductStock
    {
        private const int InitialSize = 4;

        private IProduct[] products;

        public ProductStock()
        {
            this.products = new IProduct[InitialSize];
        }

        public int Count { get; set; }

        public int Capacity 
            => this.products.Length;

        public IProduct this[int index]
        {
            get
            {
                if (index > this.Count ||
                    index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.products[index];
            }

            set
            {
                if (index > this.Count ||
                    index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                this.products[index] = value;
            }
        }

        public void Add(IProduct product)
        {
            // Check for unique lable
            // CheckSize
            // Resize
            // Add += count

            if (product == null)
            {
                throw new InvalidOperationException();
            }

            for (int i = 0; i < this.Count; i++)
            {
                if (this.products[i].CompareTo(product) == 0)
                {
                    this.products[i].Quantity += product.Quantity;
                    return;
                }
            }

            if (this.products.Length == this.Count)
            {
                this.Resize();
            }

            this.products[this.Count++] = product;
        }

        public bool Contains(IProduct product)
        {
            if (product == null)
            {
                throw new InvalidOperationException("Cannot accept null");
            }

            return this.products.Contains(product); 
        }

        public IProduct Find(int index)
        {
            try
            {
                return this.products[index - 1];
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                throw new IndexOutOfRangeException(aoore.Message, aoore);
            }
            catch (IndexOutOfRangeException ioore)
            {
                throw;
            }
        }

        public IEnumerable<IProduct> FindAllByPrice(double price)
        {
            if (price <= 0)
            {
                throw new ArgumentException(
                    "Search price cannot be zero or negative!");
            }

            List<IProduct> allProducts = new List<IProduct>();

            foreach (IProduct product in this.products)
            {
                if (product == null)
                {
                    continue;
                }
                else if (product.Price == (decimal)price)
                {
                    allProducts.Add(product);
                }
            }

            return allProducts;
        }

        public IEnumerable<IProduct> FindAllByQuantity(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException(
                    "Search quantity cannot be negative!");
            }

            List<IProduct> allProducts = new List<IProduct>();

            foreach (IProduct product in this.products)
            {
                if (product == null)
                {
                    continue;
                }
                else if (product.Quantity == quantity)
                {
                    allProducts.Add(product);
                }
            }

            return allProducts;
        }

        public IEnumerable<IProduct> FindAllInRange(double lo, double hi)
        {
            if (lo <= 0 || 
                hi <= 0)
            {
                throw new ArgumentException(
                    "Value cannot be zero or negative!");
            }

            List<IProduct> allProducts = new List<IProduct>();

            double minRange = Math.Min(lo, hi);
            double maxRange = Math.Max(lo, hi);

            foreach (IProduct product in this.products)
            {
                if (product == null)
                {
                    continue;
                }
                else if (product.Price >= (decimal)minRange &&
                         product.Price <= (decimal)maxRange)
                {
                    allProducts.Add(product);
                }
            }

            return allProducts;
        }

        public IProduct FindByLabel(string label)
        {
            if (string.IsNullOrEmpty(label))
            {
                throw new ArgumentException(
                    "Label cannot be null or empty!");
            }

            IProduct foundProduct = this.products
                .FirstOrDefault(p => p.Label == label);

            return foundProduct;
        }

        public IProduct FindMostExpensiveProduct()
        {
            IProduct expensiveProduct = null;

            decimal maxPrice = decimal.MinValue;

            foreach (IProduct product in products)
            {
                if (product == null)
                {
                    continue;
                }
                else if (product.Price > maxPrice)
                {
                    expensiveProduct = product;
                    maxPrice = product.Price;
                }
            }

            return expensiveProduct;
        }

        public bool Remove(IProduct product)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.products[i] == product)
                {
                    this.products[i] = null;

                    this.Reorder(i);

                    this.Count--;

                    if (this.Capacity / 2 == this.Count)
                    {
                        this.Shrink();
                    }

                    return true;
                }
            }

            return false;
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            for (int i = 0; i < this.products.Length; i++)
            {
                yield return this.products[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void Resize()
        {
            IProduct[] tempArray = new IProduct[this.Capacity * 2];

            for (int i = 0; i < this.Count; i++)
            {
                tempArray[i] = this.products[i];
            }

            this.products = tempArray;
        }

        private void Reorder(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.products[i] = this.products[i + 1];
            }
        }

        private void Shrink()
        {
            IProduct[] tempArray = new IProduct[this.Capacity / 2];

            for (int i = 0; i < this.Count; i++)
            {
                tempArray[i] = this.products[i];
            }

            this.products = tempArray;
        }
    }
}
