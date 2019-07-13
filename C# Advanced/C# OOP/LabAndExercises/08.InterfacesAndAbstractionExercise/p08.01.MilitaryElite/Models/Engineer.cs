using p08._01.MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace p08._01.MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private readonly List<IRepair> repairs;

        public Engineer(
            int id, 
            string firstName,
            string lastName, 
            decimal salary, 
            string corpsStr) 
            : base(id, firstName, lastName, salary, corpsStr)
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

            builder
                .AppendLine(base.ToString())
                .AppendLine("Repairs:")
                .Append($"  {string.Join("\n  ", this.Repairs)}");

            return builder.ToString().TrimEnd();
        }
    }
}
