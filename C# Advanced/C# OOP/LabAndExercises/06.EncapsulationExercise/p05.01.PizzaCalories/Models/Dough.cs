namespace p05._01.PizzaCalories.Models
{
    using System;

    using p05._01.PizzaCalories.Enums.DoughtEnums;
    using p05._01.PizzaCalories.Validations;

    public class Dough
    {
        private const int BaseCalories = 2;

        private string flourType;
        private string bakingTechnique;
        private double weightInGrams;

        public Dough(
            string flourType, 
            string bakingTechnique, 
            double weightInGrams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.WeightInGrams = weightInGrams;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }

            private set
            {
                Validation.ValidateFlourType(value);

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }

            private set
            {
                Validation.ValidateBakingTechnique(value);

                this.bakingTechnique = value;
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
                Validation.ValidateWeightInGrams(value);

                this.weightInGrams = value;
            }
        }

        public double CalculateCaloriesPerGram
        {
            get
            {
                return this.CalculateCalories();
            } 
        }

        private double CalculateCalories()
        {
            double flourDouble = TakeFlourValue();
            double bakingDouble = TakeBakingValue();

            double calories = BaseCalories * 
                              this.WeightInGrams * 
                              flourDouble * 
                              bakingDouble;

            return calories;
        }

        private double TakeBakingValue()
        {
            Baking baking = (Baking)Enum
                .Parse(typeof(Baking), this.BakingTechnique.ToLower());

            double bakingValue = 1.0;

            switch (baking)
            {
                case Baking.crispy:
                    bakingValue = 0.9;
                    break;
                case Baking.chewy:
                    bakingValue = 1.1;
                    break;
                case Baking.homemade:
                    bakingValue = 1.0;
                    break;
            }

            return bakingValue;
        }

        private double TakeFlourValue()
        {
            TypeFlour typeFlour = (TypeFlour)Enum
                .Parse(typeof(TypeFlour), this.FlourType.ToLower());

            double flourValue = 1.0;

            switch (typeFlour)
            {
                case TypeFlour.white:
                    flourValue = 1.5;
                    break;
                case TypeFlour.wholegrain:
                    flourValue = 1.0;
                    break;
            }

            return flourValue;
        }
    }
}
