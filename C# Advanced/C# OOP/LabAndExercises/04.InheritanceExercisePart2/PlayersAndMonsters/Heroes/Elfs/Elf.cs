namespace PlayersAndMonsters.Heroes.Elfs
{
    public abstract class Elf : Hero
    {
        protected Elf(string username, int level)
            : base(username, level)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
