namespace p03._01.StarEnigma
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class StarEnigma
    {
        static void Main(string[] args)
        {
            int numMessage = int.Parse(Console.ReadLine());
            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();

            for (int i = 0; i < numMessage; i++)
            {
                string line = Console.ReadLine();
                int count = 0;
                string decryptMessage = string.Empty;

                Regex keyPattern = new Regex(@"[STARstar]+");

                MatchCollection matchKey = keyPattern.Matches(line);
                
                foreach (Match letter in matchKey)
                {
                    count += letter.Length;
                }

                foreach (var symbol in line)
                {
                    char currentSymbol = symbol;

                    int sum = currentSymbol - count;
                    char @char = Convert.ToChar(sum);
                    decryptMessage += @char;
                }

                Regex pattern = new Regex
                (
                    @"@(?<planet>[A-Za-z]+)[^@\-!:>]*\:(?<population>\d+)[^@\-!:>]*!(?<attacker>[A|D])![^@\-!:>]*\->(?<soldiers>\d+)"
                );

                Match matchPlanetsArgs = pattern.Match(decryptMessage);

                if (matchPlanetsArgs.Success)
                {
                    string planetName = matchPlanetsArgs.Groups["planet"].Value;
                    char attacker = char.Parse(matchPlanetsArgs.Groups["attacker"].Value);

                    if (attacker == 'A')
                    {
                        attackedPlanet.Add(planetName);
                    }
                    else if (attacker == 'D')
                    {
                        destroyedPlanet.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");

            foreach (var planet in attackedPlanet
                .OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");

            foreach (var planet in destroyedPlanet
                .OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
