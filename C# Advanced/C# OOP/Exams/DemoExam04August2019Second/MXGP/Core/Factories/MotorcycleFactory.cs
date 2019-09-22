namespace MXGP.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using MXGP.Models.Motorcycles.Contracts;
    //using Models.Motorcycles.Contracts;

    public class MotorcycleFactory : IMotorcycleFactory
    {
        public IMotorcycle CreateMotorcycle(string type, string model, int horsePower)
        {
            Assembly assembly = Assembly
                .GetCallingAssembly();
            
            Type classType = assembly
               .GetTypes()
               .Where(x => x.Name.StartsWith(type) && !x.IsAbstract)
               .FirstOrDefault();

            if (classType == null)
            {
                throw new ArgumentException("Invalid Motorcycle Type!");
            }

            object[] parameters = new object[]
            {
                model,
                horsePower
            };

            IMotorcycle motorcycle = null;

            try
            {
                motorcycle = (IMotorcycle)Activator
                    .CreateInstance(classType, parameters);
            }
            catch (TargetInvocationException ex)
            {
                throw new ArgumentException(ex.InnerException.Message);
            }

            return motorcycle;
        }
    }
}
