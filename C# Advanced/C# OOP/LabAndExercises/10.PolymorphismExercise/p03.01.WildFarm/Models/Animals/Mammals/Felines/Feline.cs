namespace p03._01.WildFarm.Models.Animals.Mammals.Felines
{
    using Contracts;

    public abstract class Feline : Mammal, IFeline
    {
        protected Feline(
            string name, 
            double weight,
            string livingRegion,
            string breed)
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; private set; }

        public override string ToString()
        {
            string result = string.Format(base.ToString() +
                $"{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]");

            return result;
        }
    }
}
