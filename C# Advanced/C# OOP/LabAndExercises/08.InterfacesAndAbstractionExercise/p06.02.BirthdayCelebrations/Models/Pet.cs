namespace p06._02.BirthdayCelebrations.Models
{
    using p06._02.BirthdayCelebrations.Contracts;

    public class Pet : INameable, IBirthdate
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public string Birthdate { get; private set; }
    }
}
