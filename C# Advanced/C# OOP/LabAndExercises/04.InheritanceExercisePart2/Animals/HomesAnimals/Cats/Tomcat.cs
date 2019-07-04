namespace Animals.HomesAnimals.Cats
{
    using System.Text;

    public class Tomcat : Cat
    {
        private const string TomcatGender = "Male";

        public Tomcat(string name, int age)
            : base(name, age, TomcatGender)
        {
        }

        public override string ProduceSound()
        {
            string result = "MEOW";

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
