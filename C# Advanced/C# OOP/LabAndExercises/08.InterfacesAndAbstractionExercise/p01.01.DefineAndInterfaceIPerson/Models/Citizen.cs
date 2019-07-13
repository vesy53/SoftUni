namespace p01._01.DefineAndInterfaceIPerson.Models
{
    using System.Text;

    public class Citizen : IPerson
    {
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{this.Name}")
                   .Append($"{this.Age}");

            return builder.ToString();
        }
    }
}
