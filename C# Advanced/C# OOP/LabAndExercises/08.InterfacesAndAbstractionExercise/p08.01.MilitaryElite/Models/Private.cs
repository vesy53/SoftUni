namespace p08._01.MilitaryElite.Models
{
    using System.Text;

    using p08._01.MilitaryElite.Contracts;

    public class Private : Soldier, IPrivate
    {
        public Private(
            int id, 
            string firstName,
            string lastName,
            decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .Append(base.ToString())
                .Append($" Salary: {this.Salary:F2}");

            return builder.ToString();
        }
    }
}
