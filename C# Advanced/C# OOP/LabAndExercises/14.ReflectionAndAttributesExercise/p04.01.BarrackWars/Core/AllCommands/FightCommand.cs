namespace p04._01.BarrackWars.Core.AllCommands
{
    using System;

    using p04._01.BarrackWars.Contracts;

    public class FightCommand : Command
    {
        public FightCommand(
            string[] data, 
            IRepository repository,
            IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);

            return string.Empty;
        }
    }
}
