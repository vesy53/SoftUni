namespace p03._01.WildFarm.Models.Animals.Birds
{
    using System;

    using p03._01.WildFarm.Models.Foods;

    public class Hen : Bird
    {
        private const double FoodIncrease = 0.35;

        public Hen(
            string name, 
            double weight, 
            double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            this.Weight += food.Quantity * FoodIncrease;
            this.FoodEaten += food.Quantity;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
