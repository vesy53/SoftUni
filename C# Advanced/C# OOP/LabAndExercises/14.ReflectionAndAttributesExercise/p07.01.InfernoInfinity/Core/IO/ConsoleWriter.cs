namespace p07._01.InfernoInfinity.Core.IO
{
    using System;

    using p07._01.InfernoInfinity.Core.IO.Contracts;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
