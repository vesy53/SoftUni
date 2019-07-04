namespace Animals.HomesAnimals.Cats
{
    using System.Text;

    public class Kitten : Cat
    {
        private const string KittenGender = "Male";

        public Kitten(string name, int age)
            : base(name, age, KittenGender)
        {
        }

        public override string ProduceSound()
        {
            string result = "Meow";

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
