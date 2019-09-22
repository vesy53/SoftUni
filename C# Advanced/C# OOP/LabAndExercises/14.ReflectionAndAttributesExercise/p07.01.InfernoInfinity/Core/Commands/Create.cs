namespace p07._01.InfernoInfinity.Core.Commands
{
    using System;

    using p07._01.InfernoInfinity.Core.Attributes;
    using p07._01.InfernoInfinity.Data.Contracts;
    using p07._01.InfernoInfinity.Enums;
    using p07._01.InfernoInfinity.Models.Weapons.Contracts;

    public class Create : Command
    {
        public Create(
            string[] data, 
            IRepository repository,
            IWeaponFactory weaponFactory)
           : base(data)
        {
            this.Repository = repository;
            this.WeaponFactory = weaponFactory;
        }

        [Inject]
        public IRepository Repository { get; }

        [Inject]
        public IWeaponFactory WeaponFactory { get; }

        public override void Execute()
        {
            string[] split = this.Data[0]
                .ToString()
                .Split();

            string name = this.Data[1].ToString();
            string type = split[1];

            LevelRarity rarityLevel = (LevelRarity)Enum
                .Parse(typeof(LevelRarity), split[0]);

            var weapon = this.WeaponFactory
                .CreateWeapon(type, name, rarityLevel);

            this.Repository.AddWeapon(weapon);
        }
    }
}
