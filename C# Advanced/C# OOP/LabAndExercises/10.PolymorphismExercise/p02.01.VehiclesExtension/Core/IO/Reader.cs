namespace p02._01.VehiclesExtension.Core.IO
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
