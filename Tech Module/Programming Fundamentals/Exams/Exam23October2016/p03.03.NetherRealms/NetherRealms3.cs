namespace p03._03.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class NetherRealms3
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, 
                    StringSplitOptions
                    .RemoveEmptyEntries);

            List<Demon> demonBook = new List<Demon>();

            foreach (var name in names)
            {
                string healthPattern = @"[^\d\+\-\/\*\.]";
                string damagePattern = @"[\-\+]*\d+(\.\d+)*";
                string multiplier = @"\*";
                string divider = @"\/";

                MatchCollection healthMatches = Regex.Matches(name, healthPattern);
                MatchCollection damageMatches = Regex.Matches(name, damagePattern);
                MatchCollection multiplierMatches = Regex.Matches(name, multiplier);
                MatchCollection dividerMatches = Regex.Matches(name, divider);

                int health = healthMatches
                    .Cast<Match>()
                    .Select(x => (int)(Char.Parse(x.Value)))
                    .Sum();

                double damage = damageMatches
                    .Cast<Match>()
                    .Select(x => double.Parse(x.Value))
                    .Sum();

                if (multiplierMatches.Count > 0)
                {
                    damage *= Math.Pow(2, multiplierMatches.Count);
                }

                if (dividerMatches.Count > 0)
                {
                    damage /= Math.Pow(2, dividerMatches.Count);
                }

                Demon demon = new Demon
                {
                    Name = name,
                    Damage = damage,
                    Health = health
                };

                demonBook.Add(demon);
            }

            foreach (var demon in demonBook
               .OrderBy(x => x.Name))
            {
                string name = demon.Name;
                int sumHealth = demon.Health;
                double sumDamage = demon.Damage;

                Console.WriteLine(
                    $"{name} - {sumHealth} health, {sumDamage:F2} damage");
            }
        }
    }

    class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }
}
