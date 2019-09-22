namespace p05._01.BarrackWars.Core.AllCommands
{
    using System;

    public class FightCommand : Command
    {
        public FightCommand(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);

            return string.Empty;
        }
    }
}
