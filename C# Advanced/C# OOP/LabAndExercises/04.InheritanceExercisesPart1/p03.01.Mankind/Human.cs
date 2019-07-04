namespace p03._01.Mankind
{
    using System;
    using System.Text;

    public class Human
    {
        private const int DefaultLengthFirstName = 4;
        private const int DefaultLengthLastName = 3;

        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                ValidateName(value, DefaultLengthFirstName, "firstName");

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
                ValidateName(value, DefaultLengthLastName, "lastName");

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}");

            return builder.ToString().TrimEnd();
        }

        private void ValidateName(
            string value,
            int defaultLengthName,
            string parameter)
        {
            char firstLetter = value[0];

            if (!char.IsUpper(firstLetter))
            {
                throw new ArgumentException(
                    $"Expected upper case letter! Argument: {parameter}");
            }
            else if (value.Length < defaultLengthName)
            {
                throw new ArgumentException(
                    $"Expected length at least {defaultLengthName} symbols! Argument: {parameter}");
            }
        }
    }
}
