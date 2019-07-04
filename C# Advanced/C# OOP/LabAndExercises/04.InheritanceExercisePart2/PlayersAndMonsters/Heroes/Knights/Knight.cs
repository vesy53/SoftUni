namespace PlayersAndMonsters.Heroes.Knights
{
    public abstract class Knight : Hero
    {
        protected Knight(string username, int level)
            : base(username, level)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
