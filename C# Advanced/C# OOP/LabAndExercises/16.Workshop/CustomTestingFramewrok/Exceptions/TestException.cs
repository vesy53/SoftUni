namespace CustomTestingFramework.Exceptions
{
    using System;

    public class TestException : Exception
    {
        private const string ExceptionMessage = "The values are not the same.";
        
        public TestException()
            : base(ExceptionMessage)
        {
        }

        public TestException(string message) 
            : base(message)
        {
        }
    }
}
