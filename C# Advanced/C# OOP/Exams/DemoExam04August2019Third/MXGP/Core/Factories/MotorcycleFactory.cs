namespace MXGP.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using MXGP.Models.Motorcycles.Contracts;

    public class MotorcycleFactory : IMotorcycleFactory
    {
        public IMotorcycle CreateMotorcycle(string type, string model, int horsePower)
        {
            Assembly assembly = Assembly
                .GetCallingAssembly();

            Type classType = assembly
                .GetTypes()
                .Where(t => t.Name.StartsWith(type) && !t.IsAbstract)
                .FirstOrDefault();

            if (classType == null)
            {
                throw new ArgumentException("The Type Motorcycle is not valid!");
            }

            IMotorcycle motorcycle = null;

            try
            {
                motorcycle = (IMotorcycle)Activator
                .CreateInstance(classType, model, horsePower);
            }
            catch (TargetInvocationException tie)
            {
                throw new ArgumentException(tie.InnerException.Message);
            }

            return motorcycle;
        }
    }
}
