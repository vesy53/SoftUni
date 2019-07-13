namespace p08._03.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;

    using p08._03.MilitaryElite.Contracts;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private readonly List<IMission> missions;

        public Commando(
            string id, 
            string firstName, 
            string lastName, 
            decimal salary, 
            string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions 
            => this.missions;

        public void AddMission(IMission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine(base.ToString())
                .AppendLine("Missions:");

            foreach (IMission mission in this.missions)
            {
                builder
                    .AppendLine($"  {mission.ToString()}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}