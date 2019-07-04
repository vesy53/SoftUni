namespace Restaurant.Products.Foods.MainDishes
{
    public abstract class MainDish : Food
    {
        protected MainDish(string name, decimal price, double grams)
            : base(name, price, grams)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
