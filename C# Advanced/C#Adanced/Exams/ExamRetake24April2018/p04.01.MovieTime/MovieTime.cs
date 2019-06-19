namespace p04._01.MovieTime
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class MovieTime
    {
        static void Main(string[] args)
        {
            var dataMovies = new Dictionary<string, TimeSpan>();

            string genre = Console.ReadLine();
            string duration = Console.ReadLine();
            string input = Console.ReadLine();

            TimeSpan totalTime = new TimeSpan();

            while (input.Equals("POPCORN!") == false)
            {
                string[] tokens = input
                    .Split('|');

                string name = tokens[0];
                string currGenre = tokens[1];
                TimeSpan time = TimeSpan.Parse(
                        tokens[2],
                        CultureInfo
                            .InvariantCulture);

                totalTime += time;

                if (currGenre == genre)
                {
                    if (!dataMovies.ContainsKey(name))
                    {
                        dataMovies.Add(name, TimeSpan.Zero);
                    }

                    dataMovies[name] = time;
                }

                input = Console.ReadLine();
            }

            dataMovies = dataMovies
                .OrderBy(x => duration == "Short" ?
                         x.Value :
                         -x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            input = Console.ReadLine();

            foreach (var itemData in dataMovies)
            {
                string movieName = itemData.Key;
                TimeSpan movieTime = itemData.Value;

                Console.WriteLine($"{movieName}");

                if (input.Equals("Yes"))
                {
                    Console.WriteLine(
                        $"We're watching {movieName} - {movieTime}");
                    Console.WriteLine(
                        $"Total Playlist Duration: {totalTime}");

                    break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
