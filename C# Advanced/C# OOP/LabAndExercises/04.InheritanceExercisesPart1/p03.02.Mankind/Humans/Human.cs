namespace p03._01.Mankind.Humans
{
    using p03._02.Mankind.Core;
   
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
                Validation
                    .ValidateName(value, DefaultLengthFirstName, "firstName");

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
                Validation.
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
    }
}
