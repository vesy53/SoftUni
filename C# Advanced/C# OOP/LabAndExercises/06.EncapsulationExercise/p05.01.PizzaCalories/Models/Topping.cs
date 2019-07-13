namespace p05._01.PizzaCalories.Models
{
    using System;

    using p05._01.PizzaCalories.Enums;
    using p05._01.PizzaCalories.Validations;

    public class Topping
    {
        private const int BaseCalories = 2;

        private string type;
        private double weightInGrams;

        public Topping(string type, double weightInGrams)
        {
            this.Type = type;
            this.WeightInGrams = weightInGrams;
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            private set
            {
                Validation.ValidateToppingType(value);

                this.type = value;
            }
        }

        public double WeightInGrams
        {
            get
            {
                return this.weightInGrams;
            }

            private set
            {
                Validation.ValidateToppingWeight(value, this.Type);

                this.weightInGrams = value;
            }
        }

        public double CalculateCaloriesPerGram
            => this.CalculateCalories();

        private double CalculateCalories()
        {
            double toppingDouble = TakeToppingValue();

            double calories = BaseCalories * this.WeightInGrams * toppingDouble;

            return calories;
        }

        private double TakeToppingValue()
        {
            TypeTopping topping = (TypeTopping)Enum
                .Parse(typeof(TypeTopping), this.Type.ToLower());

            double toppingValue = 1.0;

            switch (topping)
            {
                case TypeTopping.meat:
                    toppingValue = 1.2;
                    break;
                case TypeTopping.veggies:
                    toppingValue = 0.8;
                    break;
                case TypeTopping.cheese:
                    toppingValue = 1.1;
                    break;
                case TypeTopping.sauce:
                    toppingValue = 0.9;
                    break;
            }

            return toppingValue;
        }
    }
}
