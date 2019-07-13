namespace p08._01.MilitaryElite.Models
{
    using System.Text;

    using p08._01.MilitaryElite.Contracts;

    public abstract class Soldier : ISoldier
    {
        protected Soldier(
            int id, 
            string firstName,
            string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .Append($"Name: {this.FirstName} {this.LastName}")
                .Append($" Id: {this.Id}");

            return builder.ToString();
        }
    }
}
