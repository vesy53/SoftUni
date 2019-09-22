namespace p06._01.TrafficLights.Core.IO
{
    using System;

    using Contracts;

    public class WriteLine : IWriteLine
    {
        public void ConsoleWriteLine()
        {
            Console.WriteLine();
        }
    }
}
