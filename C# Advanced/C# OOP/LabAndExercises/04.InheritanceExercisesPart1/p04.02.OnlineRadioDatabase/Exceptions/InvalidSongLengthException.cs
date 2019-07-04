namespace p04._02.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public override string Message => "Invalid song length.";
    }
}