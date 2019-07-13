namespace p03._01.WildFarm.Models.Foods.Factory
{
    using System;

    public class FoodFactory
    {
        public Food CreateFood(
            string type, 
            int quantity)
        {
            type = type.ToLower();

            Food food = null;

            switch (type)
            {
                case "fruit":
                    food = new Fruit(quantity);
                    break;
                case "meat":
                    food = new Meat(quantity);
                    break;
                case "seeds":
                    food = new Seeds(quantity);
                    break;
                case "vegetable":
                    food = new Vegetable(quantity);
                    break;
                default:
                    throw new ArgumentException(
                        "Invalid food type!");
            }

            return food;
        }
    }
}
