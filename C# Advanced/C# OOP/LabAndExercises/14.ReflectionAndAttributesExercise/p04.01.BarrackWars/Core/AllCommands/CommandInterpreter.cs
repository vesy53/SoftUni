namespace p04._01.BarrackWars.Core.AllCommands
{
    using System;
    using System.Linq;
    using System.Reflection;

    using p04._01.BarrackWars.Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(
            IRepository repository,
            IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
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

            IExecutable executable = (IExecutable)Activator
               .CreateInstance(
                   typeClass,
                   new object[] 
                   {
                       data,
                       this.repository,
                       this.unitFactory
                   });

            return executable;
        }
    }
}
