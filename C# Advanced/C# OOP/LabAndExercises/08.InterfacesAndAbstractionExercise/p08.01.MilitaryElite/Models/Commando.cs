namespace p08._01.MilitaryElite.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using p08._01.MilitaryElite.Contracts;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private readonly List<IMission> missions;

        public Commando(
            int id, 
            string firstName, 
            string lastName, 
            decimal salary, 
            string corpsStr) 
            : base(id, firstName, lastName, salary, corpsStr)
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
                .AppendLine("Missions:")
                .Append($"  {string.Join("\n  ", this.Missions)}");

            return builder.ToString().TrimEnd();
        }
    }
}
