namespace p01._01.Vehicles.Core.IO
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
