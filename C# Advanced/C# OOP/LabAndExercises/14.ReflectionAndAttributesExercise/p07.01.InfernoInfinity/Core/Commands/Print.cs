namespace p07._01.InfernoInfinity.Core.Commands
{
    using p07._01.InfernoInfinity.Core.Attributes;
    using p07._01.InfernoInfinity.Core.IO.Contracts;
    using p07._01.InfernoInfinity.Data.Contracts;
    using p07._01.InfernoInfinity.Models.Weapons.Contracts;

    public class Print : Command
    {
        public Print(
            string[] data, 
            IRepository repository,
            IWriter writer)
            : base(data)
        {
            this.Repository = repository;
            this.Writer = writer;
        }

        [Inject]
        public IRepository Repository { get; }

        [Inject]
        public IWriter Writer { get; }

        public override void Execute()
        {
            string name = this.Data[0];

            IWeapon weapon = this.Repository.GetWeapon(name);

            string result = this.Repository.PrintWeapon(weapon);

            Writer.WriteLine(result);
        }
    }
}
