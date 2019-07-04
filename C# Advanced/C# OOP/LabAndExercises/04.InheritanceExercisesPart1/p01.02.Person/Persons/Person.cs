namespace p01._02.Person.Persons
{
    using System.Text;

    using p01._02.Person.Core;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validation.ValidateName(value);

                this.name = value;
            }
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                Validation.ValidateAgeIsNegative(value);

                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .Append($"Name: {this.Name}, Age: {this.Age}");

            return builder.ToString().TrimEnd();
        }
    }
}
