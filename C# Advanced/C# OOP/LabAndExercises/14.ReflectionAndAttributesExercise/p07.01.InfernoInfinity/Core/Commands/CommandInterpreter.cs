namespace p07._01.InfernoInfinity.Core.Commands
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using p07._01.InfernoInfinity.Core.Attributes;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider provider)
        {
            this.serviceProvider = provider;
        }

        public IExecutable InterpretCommand(string[] data)
        {
            string commandType = data[0];
            data = data
                .Skip(1)
                .ToArray();

            Assembly assembly = Assembly
                .GetExecutingAssembly();

            var model = assembly
                .GetTypes()
                .FirstOrDefault(x => x.Name == commandType);

            if (model == null)
            {
                throw new ArgumentException(
                    "Invalid type!");
            }

            if (!typeof(IExecutable).IsAssignableFrom(model))
            {
                throw new ArgumentException(
                    model + " is not Weapon type!");
            }

            PropertyInfo[] propertiesToInject = model
                .GetProperties(BindingFlags.Instance |
                               BindingFlags.Public)
                .Where(p => p.GetCustomAttributes<InjectAttribute>().Any())
                .ToArray();

            object[] injectProps = propertiesToInject
                .Select(p => serviceProvider.GetService(p.PropertyType))
                .ToArray();

            object[] joinedParams = new object[]
            {
                data
            }.Concat(injectProps)
             .ToArray();

            IExecutable command = (IExecutable)Activator
                .CreateInstance(model, joinedParams);

            return command;
        }
    }
}
