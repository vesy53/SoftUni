namespace p01._01.Logger.Loggers
{
    using System.Linq;

    using Contracts;

    public class LogFile : ILogFile
    {
        public int Size { get; private set; }

        public void Writer(string message)
        {
            this.Size += message
                .Where(char.IsLetter)
                .Sum(x => x);
        }
    }
}
