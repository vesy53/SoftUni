namespace p07._01.AdvertisementMessage
{
    using System;
    using System.IO;

    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            /*string phrasesStr = 
                "Excellent product." + Environment.NewLine +
                "Such a great product." + Environment.NewLine +
                "I always use that product." + Environment.NewLine +
                "Best product of its category." + Environment.NewLine +
                "Exceptional product." + Environment.NewLine +
                "I can’t live without this product.";

            string eventsStr =
                "Now I feel good." + Environment.NewLine +
                "I have succeeded with this product." + Environment.NewLine +
                "Makes miracles. I am happy of the results!" + Environment.NewLine +
                "I cannot believe but now I feel awesome." + Environment.NewLine +
                "Try it yourself, I am very satisfied." + Environment.NewLine +
                "I feel great!";

            string authorStr =
                "Diana" + Environment.NewLine +
                "Petya" + Environment.NewLine +
                "Stella" + Environment.NewLine +
                "Elena" + Environment.NewLine +
                "Katya" + Environment.NewLine +
                "Iva" + Environment.NewLine +
                "Annie" + Environment.NewLine +
                "Eva";

            string citiesStr =
                "Burgas" + Environment.NewLine +
                "Sofia" + Environment.NewLine +
                "Plovdiv" + Environment.NewLine +
                "Varna" + Environment.NewLine +
                "Ruse";

            File.WriteAllText("phrases.txt", phrasesStr);
            File.WriteAllText("events.txt", eventsStr);
            File.WriteAllText("author.txt", authorStr);
            File.WriteAllText("cities.txt", citiesStr);*/

            int messages = int.Parse(Console.ReadLine());
            
            string[] phrases = File.ReadAllLines("phrases.txt");
            string[] events = File.ReadAllLines("events.txt");
            string[] author = File.ReadAllLines("author.txt");
            string[] cities = File.ReadAllLines("cities.txt");
            
            Random rand = new Random();
            File.WriteAllText("output.txt", string.Empty);
            
            for (int i = 0; i < messages; i++)
            {
                int phrasesIndex = rand.Next(0, phrases.Length);
                int eventsIndex = rand.Next(0, events.Length);
                int authorIndex = rand.Next(0, author.Length);
                int citiesIndex = rand.Next(0, cities.Length);
            
                File.AppendAllText
                (
                    "output.txt", 
                    $"{phrases[phrasesIndex]} " +
                    $"{events[eventsIndex]} " +
                    $"{author[authorIndex]} - " +
                    $"{cities[citiesIndex]}" +
                    $"{Environment.NewLine}"
                );
            }
        }
    }
}
