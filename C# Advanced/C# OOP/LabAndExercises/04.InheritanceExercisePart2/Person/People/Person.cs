namespace Person.People
{
    using System.Text;

    public abstract class Person
    {
        protected Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .Append($"Name: {this.Name}, Age: {this.Age}");

            return builder.ToString();
        }
    }
}
