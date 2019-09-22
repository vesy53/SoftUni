namespace PlayersAndMonsters.Models.Cards
{
    using System;
    using System.Text;

    using Contracts;
    using PlayersAndMonsters.Common;

    public abstract class Card : ICard
    {
        private string name;
        private int damagePoints;
        private int healthPoints;

        protected Card(
            string name,
            int damagePoints,
            int healthPoints)
        {
            this.Name = name;
            this.DamagePoints = damagePoints;
            this.HealthPoints = healthPoints;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        ExceptionMessages.InvalidCardsName);
                }

                this.name = value;
            }
        }

        public int DamagePoints
        {
            get
            {
                return this.damagePoints;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        string.Format(
                            ExceptionMessages.InvalidCardsPoints,
                            "damage points"));
                }

                this.damagePoints = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        string.Format(
                            ExceptionMessages.InvalidCardsPoints,
                            "HP"));
                }

                this.healthPoints = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(string.Format(
               ConstantMessages.CardReportInfo,
               this.Name,
               this.DamagePoints));

            return builder.ToString().TrimEnd();
        }
    }
}
