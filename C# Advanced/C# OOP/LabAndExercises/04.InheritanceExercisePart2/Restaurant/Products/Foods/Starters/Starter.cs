namespace Restaurant.Products.Foods
{
    public abstract class Starter : Food
    {
        protected Starter(string name, decimal price, double grams)
            : base(name, price, grams)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
