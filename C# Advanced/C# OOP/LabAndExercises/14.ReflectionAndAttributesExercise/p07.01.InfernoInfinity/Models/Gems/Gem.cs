namespace p07._01.InfernoInfinity.Models.Gems
{
    using Contracts;
    using p07._01.InfernoInfinity.Enums;

    public abstract class Gem : IGem
    {
        private int strength;
        private int agility;
        private int vitality;

        protected Gem(
            int strength, 
            int agility, 
            int vitality,
            LevelClarity levelClarity)
        {
            this.LevelClarity = levelClarity;
            this.Strength = strength;
            this.Agility = agility;
            this.Vitality = vitality;
        }

        public int Strength
        {
            get
            {
                return this.strength;
            }

            private set
            {
                this.strength = value + (int)this.LevelClarity;
            }
        }

        public int Agility
        {
            get
            {
                return this.agility;
            }

            private set
            {
                this.agility = value + (int)this.LevelClarity;
            }
        }

        public int Vitality
        {
            get
            {
                return this.vitality;
            }

            private set
            {
                this.vitality = value + (int)this.LevelClarity;
            }
        }

        public LevelClarity LevelClarity { get; }
    }
}
