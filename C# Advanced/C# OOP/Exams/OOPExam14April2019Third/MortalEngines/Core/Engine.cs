namespace MortalEngines.Core
{
    using System;
    using System.Reflection;
    using MortalEngines.Core.Contracts;

    using MortalEngines.IO.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(
            IReader reader,
            IWriter writer,
            ICommandInterpreter commandInterpreter)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            string input = this.reader.ReadLine();

            while (input.Equals("Quit") == false)
            {
                string[] tokens = input
                    .Split(" ", 
                        StringSplitOptions
                        .RemoveEmptyEntries);

                try
                {
                    string result = this.commandInterpreter
                        .Read(tokens);

                    this.writer.Write(result);
                }
                catch (TargetInvocationException ex)
                {
                    this.writer.Write(
                        $"Error: {ex.InnerException.Message}");
                }

                input = this.reader.ReadLine();
            }
        }
    }
}