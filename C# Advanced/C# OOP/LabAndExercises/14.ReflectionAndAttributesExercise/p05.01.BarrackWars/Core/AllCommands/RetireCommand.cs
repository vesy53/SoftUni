namespace p05._01.BarrackWars.Core.AllCommands
{
    using System;

    using p05._01.BarrackWars.Contracts;

    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;
        
        public RetireCommand(
            string[] data, 
            IRepository repository)
            : base(data)
        {
            this.Repository = repository;
        }

        public IRepository Repository
        {
            get => this.repository;
            set => this.repository = value;
        }

        public override string Execute()
        {
            string result = string.Empty;

            try
            {
                string unitType = this.Data[1];

                this.Repository.RemoveUnit(unitType);

                result = $"{unitType} retired!";
            }
            catch (InvalidOperationException ex)
            {
                result = ex.Message;
            }

            return result;
        }
    }
}
