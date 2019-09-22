namespace p06._02.ValidPerson
{
    using System;

    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) ||
                    string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidFirstNameException();
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) ||
                    string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidSecondNameException();
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < 0 ||
                    value > 120)
                {
                    throw new AgeOutOfRangeException();
                }

                this.age = value;
            }
        }
    }
}
