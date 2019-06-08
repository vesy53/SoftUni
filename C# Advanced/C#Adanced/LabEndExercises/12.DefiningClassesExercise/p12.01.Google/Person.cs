namespace p12._01.Google
{
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;
        private Car car;

        public Person(string name)
        {
            this.Name = name;

            this.Company = null;
            //this.Company = new Company(); -> with empty ctor in class Company
            this.Car = null; // without empty ctor in class Car
            //this.Car = new Car();
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public Company Company
        {
            get => this.company;
            set => this.company = value;
        }

        public List<Pokemon> Pokemons
        {
            get => this.pokemons;
            set => this.pokemons = value;
        }

        public List<Parent> Parents
        {
            get => this.parents;
            set => this.parents = value;
        }

        public List<Child> Children
        {
            get => this.children;
            set => this.children = value;
        }

        public Car Car
        {
            get => this.car;
            set => this.car = value;
        }

        public void AddCompany(Company company)
        {
            this.Company = company;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public void AddParent(Parent parent)
        {
            this.Parents.Add(parent);
        }

        public void AddChild(Child child)
        {
            this.Children.Add(child);
        }

        public void AddCar(Car car)
        {
            this.Car = car;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(this.Name);

            builder.AppendLine("Company:");
            if (this.Company != null)
            {
                builder.AppendLine(this.Company.ToString());
            }

            builder.AppendLine("Car:");
            if (this.Car != null)
            {
                builder.AppendLine(this.Car.ToString());
            }

            builder.AppendLine("Pokemon:");
            this.Pokemons
                .ForEach(p => builder.AppendLine(p.ToString()));

            builder.AppendLine("Parents:");
            this.Parents
                .ForEach(p => builder.AppendLine(p.ToString()));

            builder.AppendLine("Children:");
            this.Children
                .ForEach(c => builder.AppendLine(c.ToString()));

            return builder.ToString().TrimEnd();
        }
    }
}
