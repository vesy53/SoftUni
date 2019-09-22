namespace p02._01.ValidationAttributes
{
    using System;

    public class MyCustomException : Exception
    {
        public MyCustomException(string message)
            : base(message)
        {

        }
    }
}
