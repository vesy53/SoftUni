namespace MortalEngines.Entities.Pilots
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;
    using MortalEngines.Common;

    public class Pilot : IPilot
    {
        private string name;
        private readonly List<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;

            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(
                        ExceptionMessages.InvalidPilotName);
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new NullReferenceException(
                    ExceptionMessages.InvalidMachine);
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(
                $"{this.Name} - {this.machines.Count} machines");

            foreach (IMachine machineInfo in this.machines)
            {
                builder.AppendLine(machineInfo.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}