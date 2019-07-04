namespace Restaurant.Products.Beverages
{
    public abstract class Beverage : Product
    {
        private double milliliters;

        protected Beverage(string name, decimal price, double milliliters)
            : base(name, price)
        {
            this.Milliliters = milliliters;
        }

        public double Milliliters
        {
            get => this.milliliters;
            private set => this.milliliters = value;
        }

        public override string ToString()
        {
            string result = base.ToString() +
                $" Milliliters: {this.Milliliters:F3} ml.";

            return result;
        }
    }
}
