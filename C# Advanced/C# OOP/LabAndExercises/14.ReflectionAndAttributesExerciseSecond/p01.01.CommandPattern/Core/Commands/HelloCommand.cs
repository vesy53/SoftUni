namespace p01._01.CommandPattern.Core.Commands
{
    using p01._01.CommandPattern.Core.Contracts;

    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"Hello, {args[0]}";
        }
    }
}
