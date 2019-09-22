namespace p05._01.BarrackWars.Models.Units
{
    public class Horseman : Unit
    {
        private const int DefaultHealth = 50;
        private const int DefaultDamage = 10;

        public Horseman() 
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
