namespace p03._01.Mankind.Humans
{
    using p03._02.Mankind.Core;
    using System;
    using System.Linq;
    using System.Text;

    public class Student : Human
    {
        private const int DefaultMinLength = 5;
        private const int DefaultMaxLength = 10;

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            private set
            {
                Validation
                    .ValidateFacultyNumber(value, DefaultMinLength, DefaultMaxLength);

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine(base.ToString())
                .AppendLine($"Faculty number: {this.FacultyNumber}");

            return builder.ToString();
        }
    }
}
