namespace PlayersAndMonsters.Heroes.Knights
{
    public abstract class DarkKnight : Knight
    {
        protected DarkKnight(string username, int level)
            : base(username, level)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
