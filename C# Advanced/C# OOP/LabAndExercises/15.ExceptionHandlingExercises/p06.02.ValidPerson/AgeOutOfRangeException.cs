namespace p06._02.ValidPerson
{
    using System;

    public class AgeOutOfRangeException : Exception
    {
        private const string Message = "Age should be in range [0 ... 120].";

        public AgeOutOfRangeException()
            : base(Message)
        {
        }

        public AgeOutOfRangeException(string message) 
            : base(message)
        {
        }
    }
}
