namespace p03._02.StarEnigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class StarEnigma2
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Regex starRegex = new Regex(@"[sStTaArR]");
            Regex messageRegex = new Regex
            (
                @"[^@\-!:>]*@(?<name>[A-Za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!(?<type>A|D)![^@\-!:>]*->(\d+)[^@\-!:>]*[^@\-!:>]*"
            );

            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string line = Console.ReadLine();

                MatchCollection starMatches = starRegex.Matches(line);

                int step = starMatches.Count;

                StringBuilder decryptedMessage = new StringBuilder();

                for (int j = 0; j < line.Length; j++)
                {
                    char current = (char) (line[j] - step);

                    decryptedMessage.Append(current);
                }

                if (messageRegex.IsMatch(decryptedMessage.ToString()))
                {
                    Match match = messageRegex.Match(decryptedMessage.ToString());

                    string name = match.Groups["name"].Value;
                    string type = match.Groups["type"].Value;

                    if (type == "D")
                    {
                        destroyed.Add(name);
                    }
                    else if (type == "A")
                    {
                        attacked.Add(name);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");

            foreach (var planet in attacked
                .OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");

            foreach (var planet in destroyed
                .OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
