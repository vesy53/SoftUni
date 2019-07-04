namespace p04._01.OnlineRadioDatabase.Exceptions
{
    using System;

    public class InvalidSongException : FormatException
    {
        private const string DefaultMessage = "Invalid song.";

        public InvalidSongException(string message = DefaultMessage)
           : base(message)
        {
        }
    }
}
