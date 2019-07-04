namespace p02._01.SalaryIncrease
{
    public class Person
    {
        public Person(
            string firstName,
            string lastName,
            int age,
            decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;

            result = string.Format(
                $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.");

            return result;
        }
    }
}
