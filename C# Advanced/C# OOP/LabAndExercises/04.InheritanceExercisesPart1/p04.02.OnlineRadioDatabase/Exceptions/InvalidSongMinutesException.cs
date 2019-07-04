﻿namespace p04._02.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        public override string Message =>
            "Song minutes should be between 0 and 14.";
    }
}
