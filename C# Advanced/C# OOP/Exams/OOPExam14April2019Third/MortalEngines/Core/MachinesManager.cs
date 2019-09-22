namespace MortalEngines.Core
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using MortalEngines.Common;
    using MortalEngines.Entities.Contracts;
    using MortalEngines.Entities.Machines;
    using MortalEngines.Entities.Pilots;

    public class MachinesManager : IMachinesManager
    {
        private readonly List<IPilot> pilots;
        private readonly List<IMachine> machines;

        public MachinesManager()
        {
            this.pilots = new List<IPilot>();
            this.machines = new List<IMachine>();
        }

        public string HirePilot(string name)
        {
            bool hasExistPilot = this.pilots
                .Any(p => p.Name == name);

            if (hasExistPilot)
            {
                return string.Format(
                    OutputMessages.PilotExists,
                    name);
            }

            IPilot pilot = new Pilot(name);
            this.pilots.Add(pilot);

            return string.Format(
                OutputMessages.PilotHired,
                name);
        }

        public string ManufactureTank(
            string name, 
            double attackPoints,
            double defensePoints)
        {
            bool isExistTank = this.machines
               .Any(t => t.Name == name &&
                         t.GetType().Name == nameof(Tank));

            if (isExistTank)
            {
                return string.Format(
                    OutputMessages.MachineExists,
                    name);
            }

            IMachine tank = new Tank(name, attackPoints, defensePoints);
            this.machines.Add(tank);

            return string.Format(
                OutputMessages.TankManufactured,
                tank.Name,
                tank.AttackPoints,
                tank.DefensePoints);
        }

        public string ManufactureFighter(
            string name, 
            double attackPoints,
            double defensePoints)
        {
            bool isExistFighter = this.machines
                .Any(f => f.Name == name &&
                          f.GetType() == typeof(Fighter));

            if (isExistFighter)
            {
                return string.Format(
                    OutputMessages.MachineExists,
                    name);
            }

            IFighter fighter = new Fighter(name, attackPoints, defensePoints);
            this.machines.Add(fighter);

            return string.Format(
                OutputMessages.FighterManufactured,
                fighter.Name,
                fighter.AttackPoints,
                fighter.DefensePoints,
                fighter.AggressiveMode == true ? "ON" : "OFF");
        }

        public string EngageMachine(
            string selectedPilotName,
            string selectedMachineName)
        {
            IPilot pilot = this.pilots
                .FirstOrDefault(p => p.Name == selectedPilotName);
            IMachine machine = this.machines
                .FirstOrDefault(m => m.Name == selectedMachineName);

            if (pilot is null)
            {
                return string.Format(
                    OutputMessages.PilotNotFound,
                    selectedPilotName);
            }

            if (machine is null)
            {
                return string.Format(
                    OutputMessages.MachineNotFound,
                    selectedMachineName);
            }

            if (machine.Pilot != null)
            {
                return string.Format(
                    OutputMessages.MachineHasPilotAlready,
                    machine.Name);
            }

            pilot.AddMachine(machine);
            machine.Pilot = pilot;

            return string.Format(
                OutputMessages.MachineEngaged,
                pilot.Name,
                machine.Name);
        }

        public string AttackMachines(
            string attackingMachineName, 
            string defendingMachineName)
        {
            IMachine attacker = this.machines
                .FirstOrDefault(m => m.Name == attackingMachineName);
            IMachine defender = this.machines
                .FirstOrDefault(m => m.Name == defendingMachineName);

            if (attacker == null || defender == null)
            {
                string searchName = attacker == null
                    ? attackingMachineName
                    : defendingMachineName;

                return string.Format(
                    OutputMessages.MachineNotFound,
                    searchName);
            }

            if (attacker.HealthPoints <= 0 ||
                defender.HealthPoints <= 0)
            {
                string searchName = attacker == null
                    ? attackingMachineName
                    : defendingMachineName;

                return string.Format(
                    OutputMessages.DeadMachineCannotAttack,
                    searchName);
            }

            attacker.Attack(defender);

            return string.Format(
                OutputMessages.AttackSuccessful,
                defendingMachineName,
                attackingMachineName,
                defender.HealthPoints);
        }

        public string PilotReport(string pilotReporting)
        {
            IPilot pilot = this.pilots
                .FirstOrDefault(p => p.Name == pilotReporting);

            return pilot.Report();
        }

        public string MachineReport(string machineName)
        {
            IMachine machine = this.machines
                .FirstOrDefault(m => m.Name == machineName);

            return machine.ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            IMachine fighter = this.machines
               .FirstOrDefault(t => t.Name == fighterName &&
                                    t.GetType().Name == nameof(Fighter));

            if (!(fighter is Fighter toggleFighter))
            {
                return string.Format(
                    OutputMessages.MachineNotFound,
                    fighterName);
            }

            toggleFighter.ToggleAggressiveMode();

            return string.Format(
                OutputMessages.FighterOperationSuccessful,
                fighterName);
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            IMachine tank = this.machines
               .FirstOrDefault(t => t.Name == tankName &&
                                    t.GetType().Name == nameof(Tank));

            if (!(tank is Tank toggleTank))
            {
                return string.Format(
                    OutputMessages.MachineNotFound,
                    tankName);
            }

            toggleTank.ToggleDefenseMode();

            return string.Format(
                OutputMessages.TankOperationSuccessful,
                tankName);
        }
    }
}