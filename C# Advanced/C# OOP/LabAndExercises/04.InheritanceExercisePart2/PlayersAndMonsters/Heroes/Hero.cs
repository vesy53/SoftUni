namespace PlayersAndMonsters.Heroes
{
    public abstract class Hero
    {
        private string username;
        private int level;

        protected Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public string Username
        {
            get => this.username;
            private set => this.username = value;
        }

        public int Level
        {
            get => this.level;
            private set => this.level = value;
        }

        public override string ToString()
        {
            string result = string.Format(
                $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}");

            return result;
        }
    }

}
