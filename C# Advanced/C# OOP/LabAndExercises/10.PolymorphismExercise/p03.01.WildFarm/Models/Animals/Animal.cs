namespace p03._01.WildFarm.Models.Animals
{
    using Contracts;
    using p03._01.WildFarm.Models.Foods;

    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; set; }
                            
        public int FoodEaten { get; set; }

        public abstract void Eat(Food food);

        public abstract void ProduceSound();

        public override string ToString()
        {
            string result = string.Format(
                $"{this.GetType().Name} [{this.Name}, ");

            return result;
        }
    }
}
