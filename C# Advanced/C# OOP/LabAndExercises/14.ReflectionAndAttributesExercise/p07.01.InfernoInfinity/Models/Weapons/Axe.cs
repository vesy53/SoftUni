namespace p07._01.InfernoInfinity.Models.Weapons
{
    using p07._01.InfernoInfinity.Enums;

    public class Axe : Weapon
    {
        private const int AxeMinDamage = 5;
        private const int AxeMaxDamage = 10;
        private const int AxeNumSockets = 4;

        public Axe(string name, LevelRarity levelRarity)
            : base(name, AxeMinDamage, AxeMaxDamage, AxeNumSockets, levelRarity)
        {
        }
    }
}
