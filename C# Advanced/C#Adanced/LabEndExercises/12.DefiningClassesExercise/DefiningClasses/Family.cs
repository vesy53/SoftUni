namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.People = new List<Person>();
        }

        public List<Person> People
        {
            get
            {
                return this.people;
            }

            set
            {
                this.people = value;
            }
        }

        public void AddMember(Person person)
        {
            this.People.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = this.People
                .OrderByDescending(p => p.Age)
                .First();

            return oldestPerson;
        }
    }
}
