namespace Restaurant.Products.Foods
{
    public abstract class Food : Product
    {
        private double grams;

        protected Food(string name, decimal price, double grams)
            : base(name, price)
        {
            this.Grams = grams;
        }

        public double Grams
        {
            get => this.grams;
            private set => this.grams = value;
        }

        public override string ToString()
        {
            string result = base.ToString() +
                $" Grams: {this.Grams:F3} gr.";

            return result;
        }
    }
}
