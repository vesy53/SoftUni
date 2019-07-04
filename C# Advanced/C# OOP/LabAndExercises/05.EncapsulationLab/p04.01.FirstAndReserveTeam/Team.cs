namespace p04._01.FirstAndReserveTeam
{
    using System.Collections.Generic;
    using System.Text;

    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;

            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam 
            => this.firstTeam.AsReadOnly();

        public IReadOnlyCollection<Person> ReserveTeam 
            => this.reserveTeam.AsReadOnly();

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            if (this.firstTeam.Count > 0)
            {
                builder
                    .AppendLine($"First team has {this.firstTeam.Count} players.");
            }

            if (this.reserveTeam.Count > 0)
            {
                builder
                    .AppendLine($"Reserve team has {this.reserveTeam.Count} players.");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
