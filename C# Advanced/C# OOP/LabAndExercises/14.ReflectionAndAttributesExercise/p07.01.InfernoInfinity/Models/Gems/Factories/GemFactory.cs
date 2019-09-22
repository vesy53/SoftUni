namespace p07._01.InfernoInfinity.Models.Gems.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using p07._01.InfernoInfinity.Enums;
    using p07._01.InfernoInfinity.Models.Gems.Contracts;

    public class GemFactory : IGemFactory
    {
        public IGem CreateGem(string type, LevelClarity clarity)
        {
            Assembly assembly = Assembly
                .GetExecutingAssembly();

            Type model = assembly
                .GetTypes()
                .FirstOrDefault(c => c.Name == type);

            if (model == null)
            {
                throw new ArgumentException(
                    "Invalid type!");
            }

            if (!typeof(IGem).IsAssignableFrom(model))
            {
                throw new ArgumentException(
                    model + " is not Weapon type!");
            }

            IGem gem = (IGem)Activator
                .CreateInstance(
                    model, 
                    new object[]
                    {
                        clarity
                    });

            return gem;
        }
    }
}
