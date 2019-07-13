namespace p06._01.FootballTeamGenerator.Core.IO
{
    using System;

    using Contracts;

    public class Writer : IWriter
    {
        public void ConsoleWriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
