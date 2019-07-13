namespace p07._01.FoodShortage
{
    public class Rebel : Creature
    {
        private const int IncreaseFood = 5;

        public Rebel(string name, int age, string group)
            : base(name, age)
        {
            this.Group = group;
        }

        public string Group { get; private set; }

        public override void BuyFood()
        {
            this.Food += IncreaseFood;
        }
    }
}
