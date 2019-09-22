namespace p01._01.CommandPattern.Core.Commands
{
    using System;

    using p01._01.CommandPattern.Core.Contracts;

    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);

            return null;
        }
    }
}
