namespace p04._01.BarrackWars.Core.AllCommands
{
    using p04._01.BarrackWars.Contracts;

    public class ReportCommand : Command
    {
        public ReportCommand(
            string[] data, 
            IRepository repository,
            IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;

            return output;
        }
    }
}
