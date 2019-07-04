namespace p03._01.Mankind
{
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
                ValidateFacultyNumber(value);

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

        private void ValidateFacultyNumber(string value)
        {
            if (value.Length < DefaultMinLength || 
                value.Length > DefaultMaxLength ||
                !value.All(char.IsLetterOrDigit)) // value.Any(x => !char.IsLetterOrDigit(x))
            {
                throw new ArgumentException(
                    $"Invalid faculty number!");
            }
        }
    }
}
