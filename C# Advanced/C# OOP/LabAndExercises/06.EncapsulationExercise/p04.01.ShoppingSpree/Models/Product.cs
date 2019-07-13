namespace p04._01.ShoppingSpree.Models
{
    using p04._01.ShoppingSpree.Validations;

    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
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

        public decimal Cost
        {
            get
            {
                return this.cost;
            }

            private set
            {
                Validation.ValidateMoney(value);

                this.cost = value;
            }
        }

        public override string ToString()
        {
            string result = string
                .Format($"{this.Name}");

            return result;
        }
    }
}
