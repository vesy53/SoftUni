namespace p07._01.InfernoInfinity.Core.Commands
{
    using System;

    using p07._01.InfernoInfinity.Core.Attributes;
    using p07._01.InfernoInfinity.Data.Contracts;
    using p07._01.InfernoInfinity.Enums;
    using p07._01.InfernoInfinity.Models.Gems.Contracts;
    using p07._01.InfernoInfinity.Models.Weapons.Contracts;

    public class Add : Command
    {
        public Add(
            string[] data,
            IRepository repository, 
            IGemFactory gemFactory)
           : base(data)
        {
            this.Repository = repository;
            this.GemFactory = gemFactory;
        }

        [Inject]
        public IRepository Repository { get; }

        [Inject]
        public IGemFactory GemFactory { get; }

        public override void Execute()
        {
            string name = this.Data[0];
            int index = int.Parse(this.Data[1]);
            string[] split = this.Data[2]
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string levelClarityStr = split[0];
            string typeGem = split[1];

            LevelClarity clarity = (LevelClarity)Enum
                .Parse(typeof(LevelClarity), levelClarityStr);

            IGem gem = this.GemFactory.CreateGem(typeGem, clarity);
            IWeapon weapon = this.Repository.GetWeapon(name);

            weapon.AddGem(gem, index);
        }
    }
}
