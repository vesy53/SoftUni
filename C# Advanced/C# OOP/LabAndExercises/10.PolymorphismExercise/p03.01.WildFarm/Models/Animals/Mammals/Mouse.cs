namespace p03._01.WildFarm.Models.Animals.Mammals
{
    using System;

    using p03._01.WildFarm.Models.Foods;

    public class Mouse : Mammal
    {
        private const double FoodIncrease = 0.10;

        public Mouse(
            string name,
            double weight, 
            string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || 
                food is Fruit)
            {
                this.Weight += food.Quantity * FoodIncrease;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine(
                    $"Mouse does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            string result = string.Format(base.ToString() +
                $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]");

            return result;
        }
    }
}
