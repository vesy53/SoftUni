namespace p01._01.Cards
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Cards //60/100
    {
        static void Main(string[] args)
        {
            Regex cardPattern = new Regex(@"(10|[2-9KQJA])[SHDC]");

            string input = Console.ReadLine();

            MatchCollection matchCards = cardPattern.Matches(input);

            var resultCards = matchCards
                .Cast<Match>()
                .ToList();

            Console.WriteLine(string.Join(", ", resultCards));
        }
    }
}
