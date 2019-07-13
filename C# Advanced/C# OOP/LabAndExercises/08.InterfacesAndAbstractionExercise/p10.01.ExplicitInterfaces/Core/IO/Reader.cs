namespace p10._01.ExplicitInterfaces.Core.IO
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
