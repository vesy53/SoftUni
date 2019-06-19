namespace p04._02.MovieTime
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class MovieTime
    {
        static void Main(string[] args)
        {
            string genre = Console.ReadLine();
            string typeDuration = Console.ReadLine();
            string input = Console.ReadLine();

            List<Movie> movies = new List<Movie>();

            TimeSpan totalSeconds = new TimeSpan();

            while (input.Equals("POPCORN!") == false)
            {
                string[] tokens = input
                   .Split('|');

                string movieName = tokens[0];
                string movieGenre = tokens[1];
                TimeSpan movieTime = TimeSpan.Parse(
                            tokens[2],
                            CultureInfo
                            .InvariantCulture);

                totalSeconds += movieTime;

                if (genre == movieGenre)
                {
                    Movie currMovie = new Movie(movieName, movieTime);

                    movies.Add(currMovie);
                }

                input = Console.ReadLine();
            }

            if (typeDuration == "Short")
            {
                movies = movies.OrderBy(x => x.Duration)
                               .ThenBy(x => x.Title)
                               .ToList();
            }
            else if (typeDuration == "Long")
            {
                movies = movies.OrderByDescending(x => x.Duration)
                               .ThenBy(x => x.Title)
                               .ToList();
            }

            input = Console.ReadLine();

            foreach (Movie movie in movies)
            {
                string title = movie.Title;
                TimeSpan duration = movie.Duration;

                Console.WriteLine($"{title}");

                if (input.Equals("Yes"))
                {
                    Console.WriteLine(
                        $"We're watching {title} - {duration}");
                    Console.WriteLine(
                        $"Total Playlist Duration: {totalSeconds}");
                    break;
                }

                input = Console.ReadLine();
            }
        }
    }

    class Movie
    {
        public string Title { get; set; }

        public TimeSpan Duration { get; set; }

        public Movie(string title, TimeSpan duration)
        {
            this.Title = title;
            this.Duration = duration;
        }
    }
}