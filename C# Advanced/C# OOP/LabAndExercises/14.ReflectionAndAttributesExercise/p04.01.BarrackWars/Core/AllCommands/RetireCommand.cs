namespace p04._01.BarrackWars.Core.AllCommands
{
    using System;

    using p04._01.BarrackWars.Contracts;

    public class RetireCommand : Command
    {
        public RetireCommand(
            string[] data, 
            IRepository repository,
            IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
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
