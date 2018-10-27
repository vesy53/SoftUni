namespace p01._02.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Cards2  //100/100 
    {
        static void Main(string[] args)
        {
            //https://regex101.com/r/eUn4OA/1/
            Regex cardPattern = new Regex(@"(?<=[SHCD]|^)(10|[2-9KQJA])[SHDC]");

            string input = Console.ReadLine();

            MatchCollection matchCards = cardPattern.Matches(input);

            var resultCards = matchCards
                .Cast<Match>()
                .ToList();

            Console.WriteLine(string.Join(", ", resultCards));
        }
    }
}
