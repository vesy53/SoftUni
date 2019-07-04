namespace p06._01.Animals.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            string result = string.Empty;

            result = "Meow meow";

            return result;
        }
    }
}
