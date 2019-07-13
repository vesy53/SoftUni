namespace p07._01.FoodShortage
{
    public abstract class Creature : ICreature, IBuyer
    {
        private const int DefaultFood = 0;

        protected Creature(string name, int age)
        {
            this.Name = name;
            this.Age = age;

            this.Food = DefaultFood;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get; set; }

        public abstract void BuyFood();
    }
}
