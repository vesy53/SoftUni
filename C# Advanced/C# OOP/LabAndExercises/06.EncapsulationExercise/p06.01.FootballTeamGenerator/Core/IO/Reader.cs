namespace p06._01.FootballTeamGenerator.Core.IO
{
    using System;

    using Contracts;

    public class Reader : IReader
    {
        public string ConsoleReadLine()
        {
            return Console.ReadLine();
        }
    }
}
