namespace p07._01.InfernoInfinity.Models.Gems
{
    using p07._01.InfernoInfinity.Enums;

    public class Emerald : Gem
    {
        private const int EmeraldStrength = 1;
        private const int EmeraldAgility = 4;
        private const int EmeraldVitality = 9;

        public Emerald(LevelClarity levelClarity)
            : base(EmeraldStrength, EmeraldVitality, EmeraldVitality, levelClarity)
        {
        }
    }
}
