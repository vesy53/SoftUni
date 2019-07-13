namespace p03._01.WildFarm.Models.Animals.Contracts
{
    using p03._01.WildFarm.Models.Foods;

    public interface IAnimal
    {
        string Name { get; }

        double Weight { get; }

        int FoodEaten { get; }

        void ProduceSound();

        void Eat(Food food);
    }
}
