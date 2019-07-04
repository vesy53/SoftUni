namespace p03._01.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private const int WeekWorksDays = 5;
        private const int DefaultWeekSalary = 10;
        private const int MinWorkHoursPerDay = 1;
        private const int MaxWorkHoursPerDay = 12;

        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(
            string firstName, 
            string lastName, 
            decimal weekSalary, 
            decimal workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                ValidateWeekSalary(value);

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            private set
            {
                ValidateWorkHoursPerDay(value);

                this.workHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:F2}")
                .AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}")
                .AppendLine($"Salary per hour: {this.TakeSalaryPerHour():F2}");

            return builder.ToString().TrimEnd();
        }

        private decimal TakeSalaryPerHour()
        {
            decimal salaryPerHour = this.WeekSalary / WeekWorksDays;
            salaryPerHour /= this.WorkHoursPerDay;

            return salaryPerHour;
        }

        private void ValidateWeekSalary(decimal value)
        {
            if (value <= DefaultWeekSalary)
            {
                ThrowExeption("weekSalary");
            }
        }

        private void ValidateWorkHoursPerDay(decimal value)
        {
            if (value < MinWorkHoursPerDay || 
                value > MaxWorkHoursPerDay)
            {
                ThrowExeption("workHoursPerDay");
            }
        }

        private static void ThrowExeption(string parameter)
        {
            throw new ArgumentException(
                $"Expected value mismatch! Argument: {parameter}");
        }
    }
}
