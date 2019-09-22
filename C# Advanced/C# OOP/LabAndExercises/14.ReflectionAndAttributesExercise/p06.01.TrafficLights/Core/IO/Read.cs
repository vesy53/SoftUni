namespace p06._01.TrafficLights.Core.IO
{
    using System;

    using Contracts;

    public class Read : IRead
    {
        public string ConsoleReadLine()
        {
            return Console.ReadLine();
        }
    }
}
