namespace p07._01.EqualityLogic
{
    using System;
    using System.Collections.Generic;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }

            return this.Age.CompareTo(other.Age);
        }

        public override bool Equals(object obj)
        {
            //Person person = obj as Person;
            //
            //if (person == null)
            //{
            //    return false;
            //}

            if (obj is Person other)
            {
                return this.Name == other.Name && this.Age == other.Age;
            }

            return false;
            //return this.Age == person.Age && this.Name == person.Name;
        }

        public override int GetHashCode()
        {
           return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
