namespace p06._01.TrafficLights.Core.IO
{
    using System;

    using Contracts;

    public class Write : IWriter
    {
        public void ConsoleWrite(string message)
        {
            Console.Write(message);
        }
    }
}
