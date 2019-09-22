namespace p06._02.ValidPerson
{
    using System;

    public class InvalidSecondNameException : Exception
    {
        private const string Message = "The second name cannot be null or empty.";

        public InvalidSecondNameException()
            : base(Message)
        {
        }

        public InvalidSecondNameException(string message)
            : base(message)
        {
        }
    }
}
