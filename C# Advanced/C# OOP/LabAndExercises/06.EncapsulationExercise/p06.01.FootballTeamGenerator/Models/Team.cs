namespace p06._01.FootballTeamGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using p06._01.FootballTeamGenerator.Validations;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.name = name;

            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validation.ValidateName(value);

                this.name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player player = this.players
                .FirstOrDefault(p => p.Name == playerName);

            if (player != null)
            {
                this.players.Remove(player);
            }
            else
            {
                Validation.
                    ValidateMissingPlayer(playerName, this.Name);
            }
        }

        public double Raiting
        {
            get => this.CalculateAverageRating();
        }

        private double CalculateAverageRating()
        {
            double average = 0;

            if (this.players.Any())
            {
                double total = this.players
                    .Sum(p => p.SkillLevel);
                total /= this.players.Count;

                average = Math.Round(total);
            }

            return average;
        }

        public override string ToString()
        {
            string result = string.Format(
                $"{this.Name} - {this.Raiting}");

            return result;
        }
    }
}
