namespace AnimalCentre.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using global::AnimalCentre.Core.Factories.Contracts;
    using global::AnimalCentre.IO;
    using global::AnimalCentre.IO.Contracts;
    using global::AnimalCentre.Models.Contracts;

    public class AnimalFactory : IAnimalFactory
    {
        private readonly IWriter writer;

        public AnimalFactory()
        {
            this.writer = new Writer();
        }

        public IAnimal CreateAnimal(
            string type,
            string name, 
            int energy,
            int happiness,
            int procedureTime)
        {
            IAnimal animal = null;

            try
            {
                Assembly assembly = Assembly
                    .GetExecutingAssembly();

                Type classType = assembly
                    .GetTypes()
                    .FirstOrDefault(c => c.Name == type);

                object[] parameters = new object[]
                {
                    name,
                    energy,
                    happiness,
                    procedureTime
                };

                animal = (IAnimal)Activator
                    .CreateInstance(classType, parameters);
            }
            catch (TargetInvocationException tio)
            {
                throw new ArgumentException(tio.InnerException.Message);
            }

            return animal;
        }
    }
}
