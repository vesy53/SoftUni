namespace p03._01.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class NetherRealms
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine()
                .Split(new char[] { ',', ' ', '\t' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Regex patternHealth = new Regex(@"[^0-9\+\-\*\/\.]+");
            Regex patternDamage = new Regex(@"-?\d+(?:\.\d+)*");
            Regex pattern = new Regex(@"[*\/]");

            List<Demon> dataDemons = new List<Demon>();

            foreach (var demon in demons)
            {
                string name = demon;

                MatchCollection matchesHealth = patternHealth.Matches(demon);
                long sumHealth = TakeHealth(matchesHealth);

                MatchCollection matchesDamage = patternDamage.Matches(demon);
                decimal sumDamage = TakeDamage(matchesDamage);

                MatchCollection matchSymbols = pattern.Matches(demon);
                string symbols = TakeSymbols(matchSymbols);

                sumDamage = TotalDamage(symbols, sumDamage);

                Demon currDemon = new Demon()
                {
                    Name = name,
                    Health = sumHealth,
                    Damage = sumDamage
                };

                dataDemons.Add(currDemon);
            }

            PrintDemons(dataDemons);
        }

        static void PrintDemons(List<Demon> dataDemons)
        {
            foreach (var demon in dataDemons
                .OrderBy(x => x.Name))
            {
                string name = demon.Name;
                long sumHealth = demon.Health;
                decimal sumDamage = demon.Damage;

                Console.WriteLine(
                    $"{name} - {sumHealth} health, {sumDamage:F2} damage");
            }
        }

        static decimal TotalDamage(string symbols, decimal sumDamage)
        {
            foreach (var symbol in symbols)
            {
                if (symbol == '*')
                {
                    sumDamage *= 2;
                }
                else if (symbol == '/')
                {
                    sumDamage /= 2;
                }
            }

            return sumDamage;
        }

        static string TakeSymbols(MatchCollection matchSymbols)
        {
            string symbols = string.Empty;

            foreach (var symbol in matchSymbols)
            {
                symbols += symbol;
            }

            return symbols;
        }

        static decimal TakeDamage(MatchCollection matchesDamage)
        {
            decimal sumDamage = 0.0m;

            foreach (Match matchDamage in matchesDamage)
            {
                sumDamage += decimal.Parse(matchDamage.ToString());
            }

            return sumDamage;
        }

        static long TakeHealth(MatchCollection matchesHealth)
        {
            StringBuilder builder = new StringBuilder();
            long sumHealth = 0;

            foreach (Match matchHealth in matchesHealth)
            {
                builder.Append(matchHealth);
            }

            foreach (var build in builder.ToString())
            {
                sumHealth += build;
            }

            return sumHealth;
        }
    }

    class Demon
    {
        public string  Name { get; set; }

        public long Health { get; set; }

        public decimal Damage { get; set; }
    }
}
