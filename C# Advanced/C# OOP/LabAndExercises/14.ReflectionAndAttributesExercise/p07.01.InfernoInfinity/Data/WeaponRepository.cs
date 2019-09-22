namespace p07._01.InfernoInfinity.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using p07._01.InfernoInfinity.Models.Weapons.Contracts;

    public class WeaponRepository : IRepository
    {
        public WeaponRepository()
        {
            this.AvailableWeapons = new List<IWeapon>();
        }

        private List<IWeapon> AvailableWeapons { get; }

        public void AddWeapon(IWeapon weapon)
        {
            this.AvailableWeapons.Add(weapon);
        }

        public IWeapon GetWeapon(string name)
        {
            IWeapon weapon = this.AvailableWeapons
                .FirstOrDefault(x => x.Name == name);

            if (weapon == null)
            {
                throw new ArgumentException(
                    "Invalid Weapon Name!");
            }

            return weapon;
        }

        public string PrintWeapon(IWeapon weapon)
        {
            return weapon.ToString();
        }
    }
}
