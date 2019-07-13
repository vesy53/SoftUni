namespace p06._01.FootballTeamGenerator.Models
{
    using System;
    using p06._01.FootballTeamGenerator.Validations;

    public class Stat
    {
        private int endurance;
        private int sprint; 
        private int dribble;
        private int passing;
        private int shooting;

        public Stat(
            int endurance,
            int sprint, 
            int dribble, 
            int passing, 
            int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }

            private set
            {
                Validation.ValidateValue(value, "Endurance");

                this.endurance = value;
            }
        }

        public int Sprint
        {
            get
            {
                return this.sprint;
            }

            private set
            {
                Validation.ValidateValue(value, "Sprint");

                this.sprint = value;
            }
        }

        public int Dribble
        {
            get
            {
                return this.dribble;
            }

            private set
            {
                Validation.ValidateValue(value, "Dribble");

                this.dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }

            private set
            {
                Validation.ValidateValue(value, "Passing");

                this.passing = value;
            }
        }

        public int Shooting
        {
            get
            {
                return this.shooting;
            }

            private set
            {
                Validation.ValidateValue(value, "Shooting");

                this.shooting = value;
            }
        }

        public double CalculateTotalStat
        {
            get => this.SumAllStats();
        }

        private double SumAllStats()
        {
            double totalStat = this.Endurance +
                               this.Sprint +
                               this.Dribble +
                               this.Passing +
                               this.Shooting;

            return totalStat;
        }
    }
}
