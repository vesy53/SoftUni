namespace p08._01.MilitaryElite.Core.IO
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
