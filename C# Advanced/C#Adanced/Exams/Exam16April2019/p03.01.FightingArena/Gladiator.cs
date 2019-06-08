namespace p03._01.FightingArena
{
    using System.Text;

    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            int totalPower = this.GetStatPower() +
                             this.GetWeaponPower();

            return totalPower;
        }

        public int GetWeaponPower()
        {
            int totalWeapon = this.Weapon.Sharpness +
                              this.Weapon.Size +
                              this.Weapon.Solidity;

            return totalWeapon;
        }

        public int GetStatPower()
        {
            int totalStat = this.Stat.Agility +
                            this.Stat.Flexibility +
                            this.Stat.Intelligence +
                            this.Stat.Skills +
                            this.Stat.Strength;

            return totalStat;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"{this.Name} - {this.GetTotalPower()}")
                .AppendLine($"Weapon Power: {this.GetWeaponPower()}")
                .AppendLine($"Stat Power: {this.GetStatPower()}");

            return builder.ToString().TrimEnd();
        }
    }
}
