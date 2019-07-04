namespace p01._02.Person.Persons
{
    using p01._02.Person.Core;

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
                Validation.ValidateAge(value);

                base.Age = value;
            }
        }
    }
}
