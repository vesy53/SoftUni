namespace p01._01.Logger.Loggers.Contracts
{
    public interface ILogFile
    {
        void Writer(string message);

        int Size { get; }
    }
}