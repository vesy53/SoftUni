using p04._02.OnlineRadioDatabase.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace p04._02.OnlineRadioDatabase
{
    public class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string ArtistName
        {
            get
            {
                return this.artistName;
            }

            private set
            {
                Validation.ValidateArtistName(value);

                this.artistName = value;
            }
        }

        public string SongName
        {
            get
            {
                return this.songName;
            }

            private set
            {
                Validation.ValidateSongName(value);

                this.songName = value;
            }
        }

        public int Minutes
        {
            get
            {
                return this.minutes;
            }

            private set
            {
                Validation.ValidateMinutes(value);

                this.minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return this.seconds;
            }

            private set
            {
                Validation.ValidateSeconds(value);

                this.seconds = value;
            }
        }
    }
}
