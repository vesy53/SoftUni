namespace p05._01.BarrackWars.Core.AllCommands
{
    using p05._01.BarrackWars.Contracts;

    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;

        [Inject]
        private IUnitFactory unitFactory;

        public AddCommand(
            string[] data, 
            IRepository repository,
            IUnitFactory unitFactory)
            : base(data)
        {
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        public IRepository Repository
        {
            get => this.repository;
            set => this.repository = value;
        }

        public IUnitFactory UnitFactory
        {
            get => this.unitFactory;
            set => this.unitFactory = value;
        }

        public override string Execute()
        {
            string unitType = this.Data[1];

            IUnit unitToAdd = this.UnitFactory
                .CreateUnit(unitType);

            this.Repository.AddUnit(unitToAdd);

            string output = unitType + " added!";
            return output;
        }
    }
}
