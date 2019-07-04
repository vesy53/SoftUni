namespace p04._01.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const string DefaultMessage = "Song minutes should be between 0 and 14.";

        public InvalidSongMinutesException(string message = DefaultMessage)
            : base(message)
        {
        }
    }
}
