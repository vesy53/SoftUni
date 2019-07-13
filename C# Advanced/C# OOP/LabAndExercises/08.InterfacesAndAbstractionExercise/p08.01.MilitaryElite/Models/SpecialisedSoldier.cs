namespace p08._01.MilitaryElite.Models
{
    using System;
    using System.Text;

    using p08._01.MilitaryElite.Contracts;
    using p08._01.MilitaryElite.Enums;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(
            int id, 
            string firstName, 
            string lastName, 
            decimal salary,
            string corpsStr)
            : base(id, firstName, lastName, salary)
        {
            ParseCorps(corpsStr);
        }

        public Corps Corps { get; private set; }

        private void ParseCorps(string corpsStr)
        {
            bool isExistCorps = Enum
                .TryParse(corpsStr, out Corps corps);

            if (!isExistCorps)
            {
                throw new ArgumentException();
            }

            this.Corps = corps;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine(base.ToString())
                .AppendLine($"Corps: {this.Corps}");

            return builder.ToString().TrimEnd();
        }
    }
}
