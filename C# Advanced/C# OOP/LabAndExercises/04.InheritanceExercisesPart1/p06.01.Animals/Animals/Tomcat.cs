namespace p06._01.Animals.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            string result = string.Empty;

            result = "MEOW";

            return result;
        }
    }
}
