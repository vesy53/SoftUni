namespace PlayersAndMonsters.Heroes.Wizards
{
    public abstract class Wizard : Hero
    {
        protected Wizard(string username, int level)
            : base(username, level)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
