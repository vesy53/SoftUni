namespace p07._01.CustomException
{
    using System.Linq;

    public class Student
    {
        private string fullName;

        public Student(string fullName, string email)
        {
            this.FullName = fullName;
            this.Email = email;
        }

        public string FullName
        {
            get
            {
                return this.fullName;
            }

            private set
            {
                bool isContainDigit = value
                    .ToCharArray()
                    .Any(c => char.IsDigit(c));

                if (isContainDigit)
                {
                    throw new InvalidPersonNameException();
                }

                this.fullName = value;
            }
        }

        public string Email { get; private set; }
    }
}
