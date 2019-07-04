namespace p01._01.Person
{
    using System;

    public class Child : Person
    {
        public Child(string name, int age) 
            : base(name, age)
        {
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }

            set
            {
                ValidateAge(value);

                base.Age = value;
            }
        }

        private static void ValidateAge(int value)
        {
            if (value > 15)
            {
                throw new ArgumentException(
                    "Child's age must be less than 15!");
            }
        }
    }
}
