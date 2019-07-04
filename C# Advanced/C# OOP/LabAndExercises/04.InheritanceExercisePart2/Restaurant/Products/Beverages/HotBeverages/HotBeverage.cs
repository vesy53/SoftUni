namespace Restaurant.Products.Beverages.HotBeverages
{
    public abstract class HotBeverage : Beverage
    {
        protected HotBeverage(string name, decimal price, double milliliters)
            : base(name, price, milliliters)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
