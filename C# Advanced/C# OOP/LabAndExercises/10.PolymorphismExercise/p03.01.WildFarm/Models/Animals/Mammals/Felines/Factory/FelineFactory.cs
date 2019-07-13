namespace p03._01.WildFarm.Models.Animals.Mammals.Felines.Factory
{
    public class FelineFactory
    {
        public Feline CreateFeline(
            string type,
            string name,
            double weight,
            string livingRegion,
            string breed)
        {
            type = type.ToLower();

            Feline feline = null;

            switch (type)
            {
                case "cat":
                    feline = new Cat(name, weight, livingRegion, breed);
                    break;
                case "tiger":
                    feline = new Tiger(name, weight, livingRegion, breed);
                    break;
            }

            return feline;
        }
    }
}
