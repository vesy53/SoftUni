namespace p03._02.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class NetherRealms2
    {
        static void Main(string[] args)
        {
            var dataDemons = new SortedDictionary<string, Demon>();

            string[] demons = Console.ReadLine()
                .Split(new char[] { ',', ' ', '\t' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Regex patternHealth = new Regex(@"[^0-9+\-*\/\.]+");
            Regex patternDamage = new Regex(@"(\+|-)?\d*\.?\d+");
            Regex pattern = new Regex(@"[*|\/]");

            foreach (var demon in demons)
            {
                MatchCollection matchesHealth = patternHealth.Matches(demon);

                long sumHealth = TakeHealth(matchesHealth);

                MatchCollection matchesDamage = patternDamage.Matches(demon);
                MatchCollection matches = pattern.Matches(demon);

                double sumDamage = TakeDamage(matchesDamage, matches); 

                if (!dataDemons.ContainsKey(demon))
                {
                    dataDemons.Add(demon, new Demon());
                }

                dataDemons[demon].Health = sumHealth;
                dataDemons[demon].Damage = sumDamage;
            }

            PrintDemons(dataDemons);
        }

        static void PrintDemons(SortedDictionary<string, Demon> dataDemons)
        {
            foreach (var dataDemon in dataDemons)
            {
                string name = dataDemon.Key;
                long sumHealth = dataDemon.Value.Health;
                double sumDamage = dataDemon.Value.Damage;

                Console.WriteLine(
                    $"{name} - {sumHealth} health, {sumDamage:F2} damage");
            }
        }

        static double TakeDamage(
            MatchCollection matchesDamage, 
            MatchCollection matches)
        {
            double sumDamage = 0.0;

            foreach (Match matchDamage in matchesDamage)
            {
                sumDamage += double.Parse(matchDamage.ToString());
            }

            string symbols = string.Empty;

            foreach (Match match in matches)
            {
                symbols += match;
            }

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

        static long TakeHealth(MatchCollection matchesHealth)
        {
            string nameDemon = string.Empty;
            long sumHealth = 0;

            foreach (Match matchHealth in matchesHealth)
            {
                nameDemon += matchHealth;
            }

            foreach (var letter in nameDemon)
            {
                char currLetter = letter;

                sumHealth += currLetter;
            }

            return sumHealth;
        }
    }

    class Demon
    {
        public long Health { get; set; }

        public double Damage { get; set; }
    }
}
