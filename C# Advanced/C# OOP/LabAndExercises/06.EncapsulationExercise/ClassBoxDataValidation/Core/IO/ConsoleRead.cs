namespace p02._01.ClassBoxDataValidation.Core.IO
{
    using System;

    using Contracts;

    public class ConsoleRead : IReader
    {
        public string ConsoleReadLine()
        {
            return Console.ReadLine();
        }
    }
}
