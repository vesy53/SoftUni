namespace p04._01.ShoppingSpree.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using p04._01.ShoppingSpree.Validations;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;

            this.products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validation.ValidateName(value);

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }

            private set
            {
                Validation.ValidateMoney(value);

                this.money = value;
            }
        }

        public string AddProduct(Product product)
        {
            decimal cost = product.Cost;
            string productName = product.Name;

            string result = string.Empty;

            if (this.Money >= cost)
            {
                this.products.Add(product);
                this.Money -= cost;

                result = string.Format(
                    $"{this.Name} bought {productName}");
            }
            else
            {
                result = string.Format(
                    $"{this.Name} can't afford {productName}");
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"{this.Name} - ");

            if (this.products.Count() > 0)
            {
                var allProducts = this.products
                    .Select(p => p.Name);

                builder.Append(string.Join(", ", allProducts));
            }
            else
            {
                builder.Append("Nothing bought");
            }

            return builder.ToString();
        }
    }
}
