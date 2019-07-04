namespace p04._01.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const string DefaultMessage = "Song seconds should be between 0 and 59.";

        public InvalidSongSecondsException(string message = DefaultMessage) 
            : base(message)
        {
        }
    }
}
