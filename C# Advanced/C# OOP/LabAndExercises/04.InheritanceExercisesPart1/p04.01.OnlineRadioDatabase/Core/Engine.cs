namespace p04._01.OnlineRadioDatabase.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private List<Song> songs;

        public Engine()
        {
            this.songs = new List<Song>();
        }

        public void Run()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                try
                {
                    string[] input = Console.ReadLine()
                        .Split(';');

                    string artistName = input[0];
                    string songName = input[1];
                    string[] length = input[2]
                        .Split(':');

                    Validation.ValidateInputLength(input);

                    bool isMinutes = int.TryParse(length[0], out int minutes);
                    bool isSeconds = int.TryParse(length[1], out int seconds);

                    Validation.ValidateMinAndSec(isMinutes, isSeconds);

                    Song song = new Song(
                        artistName, 
                        songName, 
                        minutes, 
                        seconds);

                    songs.Add(song);

                    Console.WriteLine("Song added.");
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
            }

            Print();
        }

        private void Print()
        {
            Console.WriteLine($"Songs added: {songs.Count}");

            int totalSeconds = songs
                .Sum(x => x.Minutes * 60 + x.Seconds);

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

            Console.WriteLine(
                $"Playlist length: {time.Hours}h {time.Minutes}m {time.Seconds}s");
        }
    }
}
