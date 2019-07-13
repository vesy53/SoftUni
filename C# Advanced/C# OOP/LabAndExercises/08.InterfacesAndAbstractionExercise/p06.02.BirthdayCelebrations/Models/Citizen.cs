namespace p06._02.BirthdayCelebrations.Models
{
    using p06._02.BirthdayCelebrations.Contracts;

    public class Citizen : INameable, IIdentifiable, IBirthdate
    {
        public Citizen(
            string name,
            int age, 
            string id, 
            string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }
    }
}
