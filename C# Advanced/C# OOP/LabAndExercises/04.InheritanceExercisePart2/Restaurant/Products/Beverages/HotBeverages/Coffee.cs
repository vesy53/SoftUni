namespace Restaurant.Products.Beverages.HotBeverages
{
    public class Coffee : HotBeverage
    {
        private const decimal CoffeePrice = 3.50M;
        private const double CoffeeMilliliters = 50;

        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; private set; }

        public override string ToString()
        {
            string result = base.ToString() +
                $" Caffeine: {this.Caffeine}";

            return result;
        }
    }
}
