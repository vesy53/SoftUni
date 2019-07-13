namespace Animals.Models
{
    using Animals.Contracts;

    public abstract class Animal : IAnimal
    {
        protected Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public string Name { get; protected set; }

        public string FavouriteFood { get; protected set; }

        public virtual string ExplainSelf()
        {
            string result = string.Format(
                $"I am {this.Name} and my fovourite food is {this.FavouriteFood}");

            return result;
        }
    }
}
