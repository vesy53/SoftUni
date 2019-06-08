namespace p05._01.ComparingObjects
{
    using System;

    public class Person : IComparable<Person>
    {
        public Person(string name, string age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Town { get; private set; }


        public int CompareTo(Person other)
        {
            int compareName = this.Name.CompareTo(other.Name);
            int compareAge = this.Age.CompareTo(other.Age);
            int compareTown = this.Town.CompareTo(other.Town);

            if (compareName == 0 &&
                compareAge == 0 &&
                compareTown == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
