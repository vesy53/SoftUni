namespace AnimalCentre.Models.Animals
{
    using System.Text;

    using AnimalCentre.Common;

    public class Cat : Animal
    {
        public Cat(
            string name,
            int energy,
            int happiness,
            int procedureTime)
            : base(
                  name,
                  energy, 
                  happiness, 
                  procedureTime)
        {
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(string.Format(
                ConstantMessages.AnimalInfo,
                this.GetType().Name,
                this.Name,
                this.Happiness,
                this.Energy));

            return builder.ToString();
        }
    }
}
