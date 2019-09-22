namespace PlayersAndMonsters.Models.Players
{
    using System;
    using System.Text;

    using Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Repositories.Contracts;

    public abstract class Player : IPlayer
    {
        private string username;
        private int health;

        protected Player(
            ICardRepository cardRepository, 
            string username,
            int health)
        {
            this.CardRepository = cardRepository;
            this.Username = username;
            this.Health = health;
        }

        public ICardRepository CardRepository { get; private set; }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        ExceptionMessages.InvalidUsername);
                }

                this.username = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        ExceptionMessages.InvalidHealth);
                }

                this.health = value;
            }
        }

        public bool IsDead => this.Health <= 0;

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException(
                    ExceptionMessages.InvalidDamagePoints);
            }

            if (this.Health - damagePoints < 0)
            {
                this.Health = 0;
            }
            else
            {
                this.Health -= damagePoints;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(string.Format(
                ConstantMessages.PlayerReportInfo,
                this.Username,
                this.Health,
                this.CardRepository.Count));

            return builder.ToString().TrimEnd();
        }
    }
}
