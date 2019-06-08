namespace p06._01.CompanyRoster
{
    public class Employee
    {
        private const string DefaultEmail = "n/a";
        private const int DefaultAge = -1;

        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        //public Employee()
        //{
        //    this.Email = DefaultEmail;
        //    this.Age = DefaultAge;
        //}

        public Employee(
            string name, 
            decimal salary, 
            string position, 
            string department)
            //: this()
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = DefaultEmail;
            this.Age = DefaultAge;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public decimal Salary
        {
            get => this.salary;
            set => this.salary = value;
        }

        public string Position
        {
            get => this.position;
            set => this.position = value;
        }

        public string Department
        {
            get => this.department;
            set => this.department = value;
        }

        public string Email
        {
            get => this.email;
            set => this.email = value;
        }

        public int Age
        {
            get => this.age;
            set => this.age = value;
        }
    }
}
