namespace p08._01.MilitaryElite.Core.IO.Contracts
{
    using p08._01.MilitaryElite.Contracts;

    public interface IWriter
    {
        void ConsoleWriteLine(ISoldier soldier);
    }
}
