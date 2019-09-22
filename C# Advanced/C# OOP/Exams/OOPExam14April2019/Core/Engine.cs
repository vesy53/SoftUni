namespace MortalEngines.Core
{
    using System;

    using Contracts;
    using MortalEngines.IO;
    using MortalEngines.IO.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IMachinesManager machinesManager;

        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();
            this.machinesManager = new MachinesManager();
        }

        public void Run()
        {
            string input = this.reader.ReadCommands();

            while (input.Equals("Quit") == false)
            {
                try
                {
                    string[] tokens = input
                        .Split(" ",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string command = tokens[0];
                    string name = tokens[1];

                    string result = string.Empty;

                    switch (command)
                    {
                        case "HirePilot":
                            result = this.machinesManager
                                .HirePilot(name);
                            break;
                        case "PilotReport":
                            result = this.machinesManager
                                .PilotReport(name);
                            break;
                        case "ManufactureTank":
                            double attack = double.Parse(tokens[2]);
                            double defense = double.Parse(tokens[3]);

                            result = this.machinesManager
                                .ManufactureTank(name, attack, defense);
                            break;
                        case "ManufactureFighter":
                            double attackPoints = double.Parse(tokens[2]);
                            double defensePoints = double.Parse(tokens[3]);

                            result = this.machinesManager
                                .ManufactureFighter(name, attackPoints, defensePoints);
                            break;
                        case "MachineReport":
                            result = this.machinesManager
                                .MachineReport(name);
                            break;
                        case "AggressiveMode":
                            result = this.machinesManager
                                .ToggleFighterAggressiveMode(name);
                            break;
                        case "DefenseMode":
                            result = this.machinesManager
                                .ToggleTankDefenseMode(name);
                            break;

                        case "Engage":
                            string machineName = tokens[2];

                            result = this.machinesManager
                                .EngageMachine(name, machineName);
                            break;
                        case "Attack":
                            string defendingMachineName = tokens[2];

                            result = this.machinesManager
                                .AttackMachines(name, defendingMachineName);
                            break;
                    }

                    this.writer.WriteLine(result);
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine($"Error: {ex.Message}");
                }

                input = this.reader.ReadCommands();
            }
        }
    }
}
