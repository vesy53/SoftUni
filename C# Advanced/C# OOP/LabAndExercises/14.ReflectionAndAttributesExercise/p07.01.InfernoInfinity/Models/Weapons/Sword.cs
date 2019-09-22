namespace p07._01.InfernoInfinity.Models.Weapons
{
    using p07._01.InfernoInfinity.Enums;

    public class Sword : Weapon
    {
        private const int SwordMinDamage = 4;
        private const int SwordMaxDamage = 6;
        private const int SwordNumSockets = 3;

        public Sword(string name, LevelRarity levelRarity)
            : base(name, SwordMinDamage, SwordMaxDamage, SwordNumSockets, levelRarity)
        {
        }
    }
}
