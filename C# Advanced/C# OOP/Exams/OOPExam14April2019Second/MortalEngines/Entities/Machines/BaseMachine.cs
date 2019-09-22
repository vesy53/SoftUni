namespace MortalEngines.Entities.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MortalEngines.Common;
    using MortalEngines.Entities.Contracts;

    public abstract class BaseMachine : IMachine
    {
        private string name;
        private IPilot pilot;

        protected BaseMachine(
            string name,
            double attackPoints,
            double defensePoints,
            double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;

            this.Targets = new List<string>();
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
                        ExceptionMessages.InvalidMachineName);
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(
                        ExceptionMessages.InvalidPilot);
                }

                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets { get; private set; }

        public void Attack(IMachine target)
        {
            if (target == null)
            {
                throw new NullReferenceException(
                    ExceptionMessages.InvalidTarget);
            }

            double difference = Math.Abs(this.AttackPoints - target.DefensePoints);
            double currentPoints = target.HealthPoints - difference;

            if (currentPoints < 0)
            {
                target.HealthPoints = 0;
            }
            else
            {
                target.HealthPoints -= difference;
            }

            this.Targets.Add(target.Name);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            string targetsResult = this.Targets.Count == 0
                ? "None"
                : string.Join(",", this.Targets);

            builder.AppendLine($"- {this.Name}")
                   .AppendLine($" *Type: {this.GetType().Name}")
                   .AppendLine($" *Health: {this.HealthPoints:F2}")
                   .AppendLine($" *Attack: {this.AttackPoints:F2}")
                   .AppendLine($" *Defense: {this.DefensePoints:F2}")
                   .AppendLine($" *Targets: {targetsResult}");

            return builder.ToString().TrimEnd();
        }
    }
}