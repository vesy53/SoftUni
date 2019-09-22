namespace p07._01.InfernoInfinity.Core.Commands
{
    using p07._01.InfernoInfinity.Core.Attributes;
    using p07._01.InfernoInfinity.Data.Contracts;
    using p07._01.InfernoInfinity.Models.Weapons.Contracts;

    public class Remove : Command
    {
        public Remove(
            string[] data, 
            IRepository repository)
            : base(data)
        {
            this.Repository = repository;
        }

        [Inject]
        public IRepository Repository { get; }

        public override void Execute()
        {
            string name = this.Data[0];
            int index = int.Parse(this.Data[1]);

            IWeapon weapon = this.Repository.GetWeapon(name);

            weapon.RemoveGem(index);
        }
    }
}
