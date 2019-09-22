namespace p07._01.CustomException
{
    using System;

    public class InvalidPersonNameException : Exception
    {
        private const string Message = "Name must contains only letters!";

        public InvalidPersonNameException()
            : base(Message)
        {
        }

        public InvalidPersonNameException(string message) 
            : base(message)
        {
        }
    }
}
