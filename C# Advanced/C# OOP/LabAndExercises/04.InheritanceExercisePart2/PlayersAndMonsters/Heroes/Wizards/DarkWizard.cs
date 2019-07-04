namespace PlayersAndMonsters.Heroes.Wizards
{
    public abstract class DarkWizard : Wizard
    {
        protected DarkWizard(string username, int level)
            : base(username, level)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
