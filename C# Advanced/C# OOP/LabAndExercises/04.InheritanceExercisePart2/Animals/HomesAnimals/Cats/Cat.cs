namespace Animals.HomesAnimals.Cats
{
    using System.Text;

    public class Cat : Animal
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            string result = "Meow meow";

            return result;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(this.GetType().Name)
                   .AppendLine(base.ToString())
                   .Append(this.ProduceSound());

            return builder.ToString();
        }
    }
}
