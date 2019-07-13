namespace p10._01.ExplicitInterfaces.Core.IO
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
