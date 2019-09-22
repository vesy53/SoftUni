namespace StorageMaster.IO
{
    using System;

    using Contracts;

    public class Writer : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
