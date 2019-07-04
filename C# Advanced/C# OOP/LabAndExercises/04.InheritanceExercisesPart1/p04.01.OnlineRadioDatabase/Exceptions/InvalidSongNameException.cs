namespace p04._01.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongNameException : InvalidSongException
    {
        private const string DefaultMessage = "Song name should be between 3 and 30 symbols.";

        public InvalidSongNameException(string message = DefaultMessage)
            : base(message)
        {
        }
    }
}
