namespace p01._01.Person
{
    using System;
    using System.Text;

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
                ValidateName(value);

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
                ValidateAge(value);

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

        private static void ValidateName(string value)
        {
            if (value.Length < 3)
            {
                throw new ArgumentException(
                    "Name's length should not be less than 3 symbols!");
            }
        }

        private static void ValidateAge(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    "Age must be positive!");
            }
        }
    }
}
