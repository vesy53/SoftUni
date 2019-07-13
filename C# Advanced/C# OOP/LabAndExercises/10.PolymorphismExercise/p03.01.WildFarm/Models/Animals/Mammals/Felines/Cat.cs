namespace p03._01.WildFarm.Models.Animals.Mammals.Felines
{
    using System;

    using p03._01.WildFarm.Models.Foods;

    public class Cat : Feline
    {
        private const double FoodIncrease = 0.30;

        public Cat(
            string name, 
            double weight, 
            string livingRegion, 
            string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || 
                food is Meat)
            {
                this.Weight += food.Quantity * FoodIncrease;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine(
                    $"Cat does not eat {food.GetType().Name}!");
            }
        }


        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
