namespace p04._01.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        private const string DefaultMessage = "Invalid song length.";

        public InvalidSongLengthException(string message = DefaultMessage)
            : base(message)
        {
        }
    }
}
