namespace p07._01.InfernoInfinity.Models.Gems
{
    using p07._01.InfernoInfinity.Enums;

    public class Ruby : Gem
    {
        private const int RubyStrength = 7;
        private const int RubyAgility = 2;
        private const int RubyVitality = 5;

        public Ruby(LevelClarity levelClarity)
            : base(RubyStrength, RubyAgility, RubyVitality, levelClarity)
        {
        }
    }
}
