namespace p01._01.CommandPattern.Core.Contracts
{
    public interface ICommand
    {
        string Execute(string[] args);
    }
}
