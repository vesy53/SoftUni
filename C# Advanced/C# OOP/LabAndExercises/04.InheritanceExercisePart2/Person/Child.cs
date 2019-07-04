namespace Person
{
    using System;

    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
