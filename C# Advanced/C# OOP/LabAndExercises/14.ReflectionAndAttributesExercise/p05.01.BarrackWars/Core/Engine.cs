namespace p05._01.BarrackWars.Core
{
    using System;

    using Contracts;

    class Engine : IRunnable
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();

                    string[] data = input.Split();

                    string commandName = data[0];

                    IExecutable execute = commandInterpreter
                        .InterpretCommand(data, commandName);

                    string result = execute.Execute();

                    Console.WriteLine(result);
                    //Console.WriteLine(execute);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
