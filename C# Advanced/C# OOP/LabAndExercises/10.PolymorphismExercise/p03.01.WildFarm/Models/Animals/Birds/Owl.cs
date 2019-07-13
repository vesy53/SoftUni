namespace p03._01.WildFarm.Models.Animals.Birds
{
    using System;
    
    using p03._01.WildFarm.Models.Foods;

    public class Owl : Bird
    {
        private const double FoodIncrease = 0.25;

        public Owl(
            string name,
            double weight, 
            double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                this.Weight += food.Quantity * FoodIncrease;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine(
                    $"Owl does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
