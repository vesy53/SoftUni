namespace Person
{
    using System;
    using System.Text;

    public class Person
    {
        public Person(string name, int age)
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
