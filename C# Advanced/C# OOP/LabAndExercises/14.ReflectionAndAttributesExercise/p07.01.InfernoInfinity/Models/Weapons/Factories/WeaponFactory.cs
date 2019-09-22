namespace p07._01.InfernoInfinity.Models.Weapons.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using p07._01.InfernoInfinity.Enums;
    using p07._01.InfernoInfinity.Models.Weapons.Contracts;

    public class WeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(
            string type, 
            string name, 
            LevelRarity rarityLevel)
        {
            Assembly assembly = Assembly
                .GetExecutingAssembly();

            Type model = assembly
                .GetTypes()
                .FirstOrDefault(x => x.Name == type);

            if (model == null)
            {
                throw new ArgumentException(
                    "Invalid type!");
            }

            if (!typeof(IWeapon).IsAssignableFrom(model))
            {
                throw new ArgumentException(
                    model + " is not Weapon type!");
            }

            IWeapon weapon = (IWeapon)Activator
                .CreateInstance(
                    model, 
                    new object[] 
                    {
                        name,
                        rarityLevel
                    });

            return weapon;
        }
    }
}
