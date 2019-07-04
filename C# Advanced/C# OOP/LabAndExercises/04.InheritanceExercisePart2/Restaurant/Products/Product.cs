namespace Restaurant.Products
{
    public abstract class Product
    {
        private string name;
        private decimal price;

        protected Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }

        public decimal Price
        {
            get => this.price;
            private set => this.price = value;
        }

        public override string ToString()
        {
            string result = string.Format(
                $"Name: {this.Name} Price: {this.Price:F2} lv.");

            return result;
        }
    }
}
