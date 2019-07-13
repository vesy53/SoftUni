namespace p01._01.Vehicles.Core.IO
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
