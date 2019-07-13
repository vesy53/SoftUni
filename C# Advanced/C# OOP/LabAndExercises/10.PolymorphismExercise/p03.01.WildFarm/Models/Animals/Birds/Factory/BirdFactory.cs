namespace p03._01.WildFarm.Models.Animals.Birds.Factory
{
    public class BirdFactory
    {
        public Bird CreateBird(
            string type, 
            string name, 
            double weight, 
            double wingSize)
        {
            type = type.ToLower();

            Bird bird = null;

            switch (type)
            {
                case "hen":
                    bird = new Hen(name, weight, wingSize);
                    break;
                case "owl":
                    bird = new Owl(name, weight, wingSize);
                    break;
            }

            return bird;
        }
    }
}
