namespace p06._02.ValidPerson
{
    using System;

    public class InvalidFirstNameException : Exception
    {
        private const string Message = "The first name cannot be null or empty.";

        public InvalidFirstNameException()
            : base(Message)
        {
        }

        public InvalidFirstNameException(string message)
            : base(message)

        {
        }
    }
}
