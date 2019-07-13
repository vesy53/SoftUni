namespace p03._01.WildFarm.Models.Animals.Birds
{
    using Contracts;

    public abstract class Bird : Animal, IBird
    {
        protected Bird(
            string name, 
            double weight, 
            double wingSize)
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; private set; }

        public override string ToString()
        {
            string result = string.Format(
                base.ToString() + $"{this.WingSize}, {this.Weight}, {this.FoodEaten}]");

            return result;
        }
    }
}
