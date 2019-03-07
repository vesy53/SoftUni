namespace p03._01.NetherRealms
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Text;

    class NetherRealms
    {
        static void Main(string[] args)
        {            
            string[] demonsNames = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            List<Demon> demons = new List<Demon>();

            for (int i = 0; i < demonsNames.Length; i++)
            {
                Regex healthPattern = new Regex(@"(?<healt>[^0-9\+\-\*\/\.]+)");
                Regex damagePattern = new Regex(@"(?<num>-?\d+\.?\d*)");
                //Regex damagePattern = new Regex(@"(?<num>[+|\-]?\d+(\.)?(\d+)?)");
                Regex symbolsPattern = new Regex(@"(?<symbols>[*\/]+)");

                MatchCollection healthMatch = healthPattern.Matches(demonsNames[i]);
                MatchCollection damageMatch = damagePattern.Matches(demonsNames[i]);
                MatchCollection symbolsMatch = symbolsPattern.Matches(demonsNames[i]);

                int sumHealth = TakeHealth(healthMatch);

                double damage = TakeDamage(damageMatch, symbolsMatch);

                Demon currentDemon = new Demon
                (
                    demonsNames[i],
                    sumHealth,
                    damage
                 );

                demons.Add(currentDemon);
            }

            PrintDemons(demons);
        }

        static void PrintDemons(List<Demon> demons)
        {
            foreach (var demon in demons
                .OrderBy(x => x.Name))
            {
                string name = demon.Name;
                int health = demon.Health;
                double damage = demon.Damage;

                Console.WriteLine(
                    $"{name} - {health} health, {damage:F2} damage");
            }
        }

        static double TakeDamage(
            MatchCollection damageMatch,
            MatchCollection symbolsMatch)
        {
            double damage = 0.0;

            foreach (Match match in damageMatch)
            {
                string currentNum = match.Groups["num"].Value;
                double result = double.Parse(currentNum.ToString());
                damage += result;
            }

            StringBuilder builder = new StringBuilder();

            foreach (Match symbol in symbolsMatch)
            {
                builder.Append(symbol.Value);
            }

            string operands = builder.ToString();

            foreach (var operand in operands)
            {
                char currentOperand = operand;

                if (currentOperand == '*')
                {
                    damage *= 2;
                }
                else if (currentOperand == '/')
                {
                    damage /= 2;
                }
            }

            return damage;
        }

        static int TakeHealth(MatchCollection healthMatch)
        {
            int sumHealth = 0;
            string health = string.Empty;

            foreach (Match item in healthMatch)
            {
                health += item;
            }

            foreach (var item in health)
            {
                sumHealth += item;
            }

            return sumHealth;
        }
    }

    class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }

        public Demon(string name, int health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }
    }
}
