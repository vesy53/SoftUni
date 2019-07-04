namespace p04._01.OnlineRadioDatabase.Exceptions
{
    public class InvalidArtistNameException : InvalidSongException
    {
        private const string DefaultMessage = "Artist name should be between 3 and 20 symbols.";

        public InvalidArtistNameException(string message = DefaultMessage)
            : base(message)
        {
        }
    }
}
