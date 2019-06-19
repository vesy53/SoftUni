namespace p03._01.HealthyHeaven
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Salad
    {
        private List<Vegetable> products;

        public Salad(string name)
        {
            this.Name = name;

            this.products = new List<Vegetable>();
        }

        public string Name { get; private set; }

        public int GetTotalCalories()
        {
            return this.products
                .Sum(p => p.Calories);
        }

        public int GetProductCount() => this.products.Count();

        public void Add(Vegetable product)
        {
            this.products.Add(product);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            int calories = this.GetTotalCalories();
            int productCount = this.GetProductCount();

            builder.AppendLine(
                $"* Salad {this.Name} is {calories} calories and have {productCount} products:");

            foreach (Vegetable product in this.products)
            {
                builder
                    .AppendLine($"{product}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
