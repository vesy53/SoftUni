namespace p05._01.PizzaCalories.Validations
{
    using System;
    using System.Collections.Generic;

    using p05._01.PizzaCalories.Enums;
    using p05._01.PizzaCalories.Enums.DoughtEnums;
    using p05._01.PizzaCalories.Models;

    public static class Validation
    {
        private const int MinWeightInGrams = 1;
        private const int MaxWeightInGrams = 200;
        private const int ToppingMaxWeight = 50;
        private const int MinPizzaNameLength = 1;
        private const int MaxPizzaNameLength = 15;
        private const int MinPizzaToppingsCount = 0;
        private const int MaxPizzaToppingsCount = 10;

        // Pizza validations
        public static void ValidatePizzaName(string value)
        {
            if (string.IsNullOrEmpty(value) ||
                string.IsNullOrWhiteSpace(value) ||
                value.Length < MinPizzaNameLength ||
                value.Length > MaxPizzaNameLength)
            {
                throw new ArgumentException(
                    ExceptoionsMessages.InvalidPizzaName);
            }
        }

        public static void ValidatePizzaToppingCount(List<Topping> toppings)
        {
            if (toppings.Count < MinPizzaToppingsCount ||
                toppings.Count > MaxPizzaToppingsCount)
            {
                throw new ArgumentException(
                    ExceptoionsMessages.InvalidToppingsCount);
            }
        }

        // Topping validations
        public static void ValidateToppingType(string value)
        {
            bool isExist = Enum
                .TryParse(value.ToLower(), out TypeTopping typeTopping);

            if (!isExist)
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptoionsMessages
                        .InvalidToppingType,
                        value));
            }
        }

        public static void ValidateToppingWeight(
            double value,
            string typeName)
        {
            if (value < MinWeightInGrams || 
                value > ToppingMaxWeight)
            {
                throw new ArgumentException(
                    string.Format(
                        ExceptoionsMessages
                        .InvalidToppingWeight,
                        typeName));
            }
        }

        // Dought validations
        public static void ValidateFlourType(string value)
        {
            bool isExit = Enum
                .TryParse(value.ToLower(), out TypeFlour typeFlour);

            ThrowArgExeption(isExit);
        }

        public static void ValidateBakingTechnique(string value)
        {
            bool isExit = Enum
                .TryParse(value.ToLower(), out Baking baking);

            ThrowArgExeption(isExit);
        }

        public static void ValidateWeightInGrams(double value)
        {
            if (value < MinWeightInGrams ||
                value > MaxWeightInGrams)
            {
                throw new ArgumentException(
                    ExceptoionsMessages.InvalidDoughWeight);
            }
        }

        private static void ThrowArgExeption(bool isExit)
        {
            if (!isExit)
            {
                throw new ArgumentException(
                    ExceptoionsMessages.InvalidDough);
            }
        }
    }
}
