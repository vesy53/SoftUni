namespace p03._01.HealthyHeaven
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Restaurant
    {
        private List<Salad> data;

        public Restaurant(string name)
        {
            this.Name = name;

            this.data = new List<Salad>();
        }

        public string Name { get; private set; }

        public void Add(Salad salad)
        {
            this.data.Add(salad);
        }

        public bool Buy(string name)
        {
            Salad salad = this.data
                .Where(d => d.Name == name)
                .FirstOrDefault();

            if (salad != null)
            {
                this.data.Remove(salad);

                return true;
            }

            return false;
        }

        public Salad GetHealthiestSalad()
        {
            Salad salad = this.data
                .OrderBy(d => d.GetTotalCalories())
                .FirstOrDefault();

            return salad;
        }

        public string GenerateMenu()
        {
            StringBuilder builder = new StringBuilder();

            int saladCount = this.data.Count();

            builder
                .AppendLine($"{this.Name} have {saladCount} salads:");

            foreach (Salad salad in this.data)
            {
                builder.AppendLine($"{salad}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
