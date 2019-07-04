namespace Animals.HomesAnimals
{
    using System.Text;

    public class Frog : Animal
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            string result = "Ribbit";

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
