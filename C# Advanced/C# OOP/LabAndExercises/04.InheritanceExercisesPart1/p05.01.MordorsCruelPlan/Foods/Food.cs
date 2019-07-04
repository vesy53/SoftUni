namespace p05._01.MordorsCruelPlan.Foods
{
    public abstract class Food
    {
        public Food(int happines)
        {
            this.Happiness = happines;
        }

        public int Happiness { get; private set; }
    }
}