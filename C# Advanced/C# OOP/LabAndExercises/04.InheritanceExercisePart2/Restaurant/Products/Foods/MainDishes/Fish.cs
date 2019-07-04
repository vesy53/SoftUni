namespace Restaurant.Products.Foods.MainDishes
{
    public class Fish : MainDish
    {
        private const double FishGrams = 22;

        public Fish(string name, decimal price)
            : base(name, price, FishGrams)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
