namespace p04._02.OnlineRadioDatabase.Core
{
    using p04._02.OnlineRadioDatabase.Exceptions;

    public static class Validation
    {
        private const int NameMinLength = 3;
        private const int ArtistNameMaxLength = 20;
        private const int SongNameMaxLength = 30;
        private const int DefaultMinAndSec = 0;
        private const int DefaultMaxMinutes = 14;
        private const int DefaultMaxSecond = 59;

        public static void ValidateArtistName(string value)
        {
            if (value.Length < NameMinLength ||
                value.Length > ArtistNameMaxLength)
            {
                throw new InvalidArtistNameException();
            }
        }

        public static void ValidateSongName(string value)
        {
            if (value.Length < NameMinLength ||
                value.Length > SongNameMaxLength)
            {
                throw new InvalidSongNameException();
            }
        }

        public static void ValidateMinutes(int value)
        {
            if (value < DefaultMinAndSec ||
                value > DefaultMaxMinutes)
            {
                throw new InvalidSongMinutesException();
            }
        }

        public static void ValidateSeconds(int value)
        {
            if (value < DefaultMinAndSec ||
                value > DefaultMaxSecond)
            {
                throw new InvalidSongSecondsException();
            }
        }

        public static void ValidateInputLength(string[] input)
        {
            if (input.Length != NameMinLength)
            {
                throw new InvalidSongException();
            }
        }

        public static void ValidateMinAndSec(bool isMinutes, bool isSeconds)
        {
            if (!isMinutes ||
                !isSeconds)
            {
                throw new InvalidSongLengthException();
            }
        }
    }
}
