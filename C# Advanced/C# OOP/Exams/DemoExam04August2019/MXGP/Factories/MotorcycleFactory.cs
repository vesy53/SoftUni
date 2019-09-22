namespace MXGP.Factories
{
    using MXGP.Models.Motorcycles;
    using MXGP.Models.Motorcycles.Contracts;

    public class MotorcycleFactory
    {
        public IMotorcycle CreateMotorcycle(string type, string model, int horsePower)
        {
            type += "Motorcycle";

            IMotorcycle motorcycle = null;

            switch (type)
            {
                case "PowerMotorcycle":
                    motorcycle = new PowerMotorcycle(model, horsePower);
                    break;
                case "SpeedMotorcycle":
                    motorcycle = new SpeedMotorcycle(model, horsePower);
                    break;
            }

            return motorcycle;
        }
    }
}
