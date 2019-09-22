namespace MortalEngines.IO
{
    using System;
    
    using Contracts;

    public class Writer : IWriter
    {
        public void WriteLine(string content)
        {
            Console.WriteLine(content);
        }
    }
}
