namespace p07._01.InfernoInfinity.Models.Weapons
{
    using p07._01.InfernoInfinity.Enums;

    public class Knife : Weapon
    {
        private const int KnifeMinDamage = 3;
        private const int KnifeMaxDamage = 4;
        private const int KnifeNumSockets = 2;

        public Knife(string name, LevelRarity levelRarity)
            : base(name, KnifeMinDamage, KnifeMaxDamage, KnifeNumSockets, levelRarity)
        {
        }
    }
}
