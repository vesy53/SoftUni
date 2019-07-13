namespace p08._01.MilitaryElite.Core.IO
{
    using System;

    using Contracts;
    using p08._01.MilitaryElite.Contracts;

    public class Writer : IWriter
    {
        public void ConsoleWriteLine(ISoldier soldier)
        {
            Console.WriteLine(soldier);
        }
    }
}
