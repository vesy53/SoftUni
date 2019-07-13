namespace p08._03.MilitaryElite.Models
{
    using System.Text;
    using System.Collections.Generic;

    using p08._03.MilitaryElite.Contracts;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly List<ISoldier> privates;

        public LieutenantGeneral(
            string id, 
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

            builder.AppendLine(base.ToString());
            builder.AppendLine("Privates:");

            foreach (ISoldier currentPrivate in this.Privates)
            {
                builder.AppendLine(
                    $"  {currentPrivate.ToString().TrimEnd()}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}