namespace p08._03.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;

    using p08._03.MilitaryElite.Contracts;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private readonly List<IRepair> repairs;

        public Engineer(
            string id, 
            string firstName,
            string lastName,
            decimal salary, 
            string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs 
            => this.repairs;

        public void AddRepair(IRepair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(base.ToString());
            builder.AppendLine("Repairs:");

            foreach (IRepair repair in this.Repairs)
            {
                builder
                    .AppendLine($"  {repair.ToString()}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}