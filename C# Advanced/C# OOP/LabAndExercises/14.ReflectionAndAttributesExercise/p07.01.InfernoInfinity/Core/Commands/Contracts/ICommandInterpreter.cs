namespace p07._01.InfernoInfinity.Core.Commands.Contracts
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] input);
    }
}
