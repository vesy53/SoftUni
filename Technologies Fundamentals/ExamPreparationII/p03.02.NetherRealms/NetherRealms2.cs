namespace p03._02.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class NetherRealms2
    {
        static void Main(string[] args)
        {
            string[] demonsNames = Console.ReadLine()
                .Split(new string[] { ", ", "\t" },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .OrderBy(x => x)
                .ToArray();

            List<Demon> demons = new List<Demon>(demonsNames.Length);

            foreach (string name in demonsNames)
            {
                demons.Add(new Demon { Name = name });
            }

            foreach (Demon demon in demons)
            {
                string healthData = Regex.Replace(demon.Name, @"[0-9\.+-/*]+", string.Empty);
                int health = 0;

                for (int i = 0; i < healthData.Length; i++)
                {
                    health += healthData[i];
                }

                demon.Health = health;
            }

            foreach (Demon demon in demons)
            {
                MatchCollection matches = Regex.Matches(demon.Name, @"[-+]{0,1}[0-9]+\.?[0-9]{0,}");
                List<double> damageData = new List<double>(matches.Count);

                foreach (Match match in matches)
                {
                    damageData.Add(double.Parse(match.Value));
                }

                demon.Damage = damageData.Count > 0 ? damageData[0] : 0;

                for (int i = 1; i < damageData.Count; i++)
                {
                    demon.Damage += damageData[i];
                }

                if (demon.Name.Contains('/') || demon.Name.Contains('*'))
                {
                    MatchCollection matchesSymbols = Regex.Matches(demon.Name, @"[/*]+");
                    StringBuilder sb = new StringBuilder();

                    foreach (Match match in matchesSymbols)
                    {
                        sb.Append(match.Value);
                    }

                    string operands = sb.ToString();

                    foreach (char operand in operands)
                    {
                        switch (operand)
                        {
                            case '*':
                                demon.Damage *= 2;
                                break;
                            case '/':
                                demon.Damage /= 2;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            foreach (var demon in demons)
            {
                string name = demon.Name;
                int health = demon.Health;
                double damage = demon.Damage;

                Console.WriteLine(
                    $"{name} - {health} health, {damage:F2} damage");
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
