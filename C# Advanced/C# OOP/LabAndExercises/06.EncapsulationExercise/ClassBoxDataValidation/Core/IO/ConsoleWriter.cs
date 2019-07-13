namespace p02._01.ClassBoxDataValidation.Core.IO
{
    using System;

    using Contracts;

    public class ConsoleWriter : IWriter
    {
        public void ConsoleWriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
