namespace p08._01.MilitaryElite.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using p08._01.MilitaryElite.Contracts;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private  readonly List<ISoldier> privates;

        public LieutenantGeneral(
            int id, 
            string firstName, 
            string lastName, 
            decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates 
            => this.privates;

        public void AddPrivate(ISoldier newPrivate)
        {
            this.privates.Add(newPrivate);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine(base.ToString())
                .AppendLine("Privates:")
                .Append($"  {string.Join("\n  ", this.privates)}");

            return builder.ToString().TrimEnd();
        }
    }
}
