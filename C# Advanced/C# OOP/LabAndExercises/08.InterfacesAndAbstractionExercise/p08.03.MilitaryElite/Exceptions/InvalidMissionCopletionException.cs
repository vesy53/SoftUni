namespace p08._03.MilitaryElite.Exceptions
{
    using System;

    public class InvalidMissionCopletionException : Exception
    {
        private const string EXC_MESSAGE = 
            "You cannot finish already completed mission!";

        public InvalidMissionCopletionException()
            : base(EXC_MESSAGE)
        {

        }

        public InvalidMissionCopletionException(string message) 
            : base(message)
        {

        }
    }
}