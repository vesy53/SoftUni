namespace p05._01.BarrackWars.Core.AllCommands
{
    using System;
    using System.Linq;
    using System.Reflection;

    using p05._01.BarrackWars.Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IExecutable InterpretCommand(
            string[] data, 
            string commandName)
        {
            Assembly assembly = Assembly
                .GetExecutingAssembly();

            Type typeClass = assembly
                .GetTypes()
                .First(y => y.Name.ToLower() == commandName + "command");

            FieldInfo[] fieldsToInject = typeClass
               .GetFields(BindingFlags.Instance | 
                          BindingFlags.NonPublic)
               .Where(f => f.CustomAttributes
                            .Any(ca => ca.AttributeType == typeof(InjectAttribute)))
               .ToArray();

            object[] injectArgs = fieldsToInject
                .Select(f => this.serviceProvider.GetService(f.FieldType))
                .ToArray();

            object[] constrArgs = new object[]
            {
                data
            }.Concat(injectArgs)
             .ToArray();

            IExecutable executable = (IExecutable)Activator
                .CreateInstance(typeClass, constrArgs);

            return executable;
        }
    }
}
