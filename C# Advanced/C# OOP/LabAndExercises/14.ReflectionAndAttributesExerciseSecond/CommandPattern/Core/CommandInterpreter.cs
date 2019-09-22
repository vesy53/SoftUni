namespace CommandPattern.Core
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandPrefix = "Command";

        public string Read(string args)
        {
            string[] tokens = args.Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string commandName = tokens[0] + CommandPrefix;
            string[] commandArguments = tokens
                .Skip(1)
                .ToArray();

            Assembly assembly = Assembly
                .GetCallingAssembly();

            Type[] allClassTypes = assembly
                .GetTypes();

            Type type = allClassTypes
                .FirstOrDefault(c => c.Name == commandName);

            Object instance = Activator
                .CreateInstance(type);

            ICommand command = (ICommand)instance;

            string result = command
                .Execute(commandArguments);

            return result;
        }
    }
}
