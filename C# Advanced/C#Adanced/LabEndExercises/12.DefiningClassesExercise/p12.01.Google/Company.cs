namespace p12._01.Google
{
    using System.Text;

    public class Company
    {
        private string name;
        private string department;
        private decimal salary;

        //public Company()
        //{
        //
        //}

        public Company(
            string name, 
            string department, 
            decimal salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }

        public string Name { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{this.Name} {this.Department} {this.Salary:F2}");

            return builder.ToString().TrimEnd();
        }
    }
}
