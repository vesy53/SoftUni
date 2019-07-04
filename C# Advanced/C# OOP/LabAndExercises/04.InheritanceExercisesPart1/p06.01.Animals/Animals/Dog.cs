namespace p06._01.Animals.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            string result = string.Empty;

            result = "Woof!";

            return result;
        }
    }
}
