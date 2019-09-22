namespace MortalEngines.Core
{
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly IMachinesManager machinesManager;

        public CommandInterpreter(IMachinesManager machinesManager)
        {
            this.machinesManager = machinesManager;
        }

        public string Read(string[] args)
        {
            string[] commandArgs = args
                .Skip(1)
                .ToArray();
            string commandName = args[0];

            if (commandName == "AggressiveMode")
            {
                commandName = "ToggleFighterAggressiveMode";
            }
            else if (commandName == "DefenseMode")
            {
                commandName = "ToggleTankDefenseMode";
            }
            else if (commandName == "Engage")
            {
                commandName = "EngageMachine";
            }
            else if (commandName == "Attack")
            {
                commandName = "AttackMachines";
            }

            MethodInfo managerMethod = typeof(MachinesManager)
                .GetMethod(commandName);

            List<object> requiredParameters = new List<object>();

            foreach (string argumentString in commandArgs)
            {
                if (double.TryParse(argumentString, out double parsedDoubleArgument))
                {
                    requiredParameters.Add(parsedDoubleArgument);
                    continue;
                }

                requiredParameters.Add(argumentString);
            }

            string result = (string)managerMethod
                .Invoke(this.machinesManager, requiredParameters.ToArray());

            return result;
        }
    }
}