namespace p06._01.Animals.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            string result = string.Empty;

            result = "Meow";

            return result;
        }
    }
}
