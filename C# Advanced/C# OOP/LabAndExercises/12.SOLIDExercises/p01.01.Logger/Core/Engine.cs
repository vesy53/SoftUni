namespace p01._01.Logger.Core
{
    using System;

    using Contracts;

    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split();

                this.commandInterpreter.AddAppender(inputArgs);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input
                    .Split('|');

                this.commandInterpreter.AddMessage(inputArgs);

                input = Console.ReadLine();
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}
