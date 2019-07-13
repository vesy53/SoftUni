namespace p05._01.PizzaCalories.Core.IO
{
    using System;

    using IO.Contracts;

    public class ConsoleWriter : IWriter
    {
        public void ConsoleWriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
