namespace p07._01.InfernoInfinity.Models.Gems
{
    using p07._01.InfernoInfinity.Enums;

    public class Amethyst : Gem
    {
        private const int AmethystStrength = 2;
        private const int AmethystAgility = 8;
        private const int AmethystVitality = 4;

        public Amethyst(LevelClarity levelClarity)
            : base(AmethystStrength, AmethystVitality, AmethystVitality, levelClarity)
        {
        }
    }
}
