namespace p08._03.MilitaryElite.Models
{
    using System;

    using p08._03.MilitaryElite.Contracts;
    using p08._03.MilitaryElite.Enums;
    using p08._03.MilitaryElite.Exceptions;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(
            string id,
            string firstName,
            string lastName,
            decimal salary, 
            string corps)
            : base(id, firstName, lastName, salary)
        {
            ParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        private void ParseCorps(string corpsStr)
        {
            bool parsed = Enum
                .TryParse(corpsStr, out Corps corps);

            if (!parsed)
            {
                throw new InvalidCorpsException();
            }

            this.Corps = corps;
        }

        public override string ToString()
        {
            return base.ToString() + 
                Environment.NewLine + 
                $"Corps: {this.Corps}";
        }
    }
}