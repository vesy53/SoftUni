namespace p07._01.InfernoInfinity.Core
{
    using System;

    using Commands.Contracts;
    using Contracts;
    using IO.Contracts;

    public class Engine : IRunable
    {
        private ICommandInterpreter commandInterpreter;
        private IWriter writer;
        private IReader reader;

        public Engine(
            ICommandInterpreter commandInterpreter,
            IWriter writer,
            IReader reader)
        {
            this.commandInterpreter = commandInterpreter;
            this.writer = writer;
            this.reader = reader;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string[] input = reader
                        .ReadLine()
                        .Split(";",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    IExecutable command = this.commandInterpreter
                        .InterpretCommand(input);

                    command.Execute();
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
