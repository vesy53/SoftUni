namespace p03._01.Mankind.Humans
{
    using p03._02.Mankind.Core;
    using System;
    using System.Text;

    public class Worker : Human
    {
        private const int WeekWorksDays = 5;
        private const decimal DefaultWeekSalary = 10;
        private const decimal MinWorkHoursPerDay = 1;
        private const decimal MaxWorkHoursPerDay = 12;

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
                Validation
                    .ValidateWeekSalary(value, DefaultWeekSalary);

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
                Validation
                    .ValidateWorkHoursPerDay(value, MinWorkHoursPerDay, MaxWorkHoursPerDay);

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
    }
}
