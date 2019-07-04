namespace p03._01.ValidationOfData
{
    using p03._01.ValidationOfData.Core;

    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

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

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Validation.ValidateName(value, "First");

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                Validation.ValidateName(value, "Last");

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                Validation.ValidateAge(value);

                this.age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            private set
            {
                Validation.ValidateSalary(value);

                this.salary = value;
            }
        }

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
                $"{this.FirstName} {this.LastName} gets {this.Salary:F2} leva.");

            return result;
        }
    }
}
