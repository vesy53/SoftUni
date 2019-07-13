namespace p05._01.PizzaCalories.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using p05._01.PizzaCalories.Validations;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;

            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validation.ValidatePizzaName(value);

                this.name = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }

            private set
            {
                this.dough = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            Validation
                .ValidatePizzaToppingCount(this.toppings);

            this.toppings.Add(topping);
        }

        public double CalculatePizzaCalories
            => CalculateCalories();

        public override string ToString()
        {
            string result = string.Format(
                $"{this.Name} - {this.CalculatePizzaCalories:F2} Calories.");

            return result;
        }

        private double CalculateCalories()
        {
            double toppingsCalories = this.toppings
                .Sum(t => t.CalculateCaloriesPerGram);

            double doughCalories = this.Dough
                .CalculateCaloriesPerGram;

            double totalCalories = toppingsCalories + doughCalories;

            return totalCalories;
        }
    }
}
