namespace p06._01.FootballTeamGenerator.Models
{
    using p06._01.FootballTeamGenerator.Validations;

    public class Player
    {
        private string name;
        private Stat stat;

        public Player(string name, Stat stat)
        {
            this.Name = name;
            this.Stat = stat;
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

        public Stat Stat
        {
            get => this.stat;
            set => this.stat = value;
        }

        public double SkillLevel
        {
            get => this.CalculateAverageStat();
        }

        private double CalculateAverageStat()
        {
            double totalStat = this.Stat.CalculateTotalStat;

            double avergeStat = totalStat / 5.0;

            return avergeStat;
        }
    }
}
