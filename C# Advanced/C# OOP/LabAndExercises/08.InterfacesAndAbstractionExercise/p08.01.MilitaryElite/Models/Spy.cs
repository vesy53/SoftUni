namespace p08._01.MilitaryElite.Models
{
    using System.Text;

    using p08._01.MilitaryElite.Contracts;

    public class Spy : Soldier, ISpy
    {
        public Spy(
            int id, 
            string firstName, 
            string lastName,
            int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine(base.ToString())
                .AppendLine($"Code Number: {this.CodeNumber}");

            return builder.ToString().TrimEnd();
        }
    }
}
