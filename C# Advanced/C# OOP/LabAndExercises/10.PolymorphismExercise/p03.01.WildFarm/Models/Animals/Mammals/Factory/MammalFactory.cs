namespace p03._01.WildFarm.Models.Animals.Mammals.Factory
{
    public class MammalFactory
    {
        public Mammal CreateMammal(
            string type,
            string name,
            double weight,
            string livingRegion)
        {
            type = type.ToLower();

            Mammal mammal = null;

            switch (type)
            {
                case "dog":
                    mammal = new Dog(name, weight, livingRegion);
                    break;
                case "mouse":
                    mammal = new Mouse(name, weight, livingRegion);
                    break;
            }

            return mammal;
        }
    }
}
