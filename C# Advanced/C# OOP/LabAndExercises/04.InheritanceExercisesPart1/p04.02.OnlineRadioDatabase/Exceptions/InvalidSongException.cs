namespace p04._02.OnlineRadioDatabase.Exceptions
{
    using System;

    public class InvalidSongException : Exception
    {
        public override string Message => "Invalid song.";
    }
}
