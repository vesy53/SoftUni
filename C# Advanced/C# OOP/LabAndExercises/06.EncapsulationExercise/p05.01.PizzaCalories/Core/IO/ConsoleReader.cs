namespace p05._01.PizzaCalories.Core.IO
{
    using System;

    using Contracts;

    public class ConsoleReader : IReader
    {
        public string ConsoleReadLine()
        {
            return Console.ReadLine();
        }
    }
}
