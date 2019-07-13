namespace p02._01.VehiclesExtension.Core.IO
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
