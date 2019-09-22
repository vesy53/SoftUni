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

                    if (command == "HirePilot")
                    {
                        result = this.machinesManager
                                .HirePilot(name);
                    }
                    else if (command == "PilotReport")
                    {
                        result = this.machinesManager
                                .PilotReport(name);
                    }
                    else if (command == "ManufactureTank")
                    {
                        double attack = double.Parse(tokens[2]);
                        double defense = double.Parse(tokens[3]);

                        result = this.machinesManager
                            .ManufactureTank(name, attack, defense);
                    }
                    else if (command == "ManufactureFighter")
                    {
                        double attackPoint = double.Parse(tokens[2]);
                        double defensePoint = double.Parse(tokens[3]);

                        result = this.machinesManager
                            .ManufactureFighter(name, attackPoint, defensePoint);
                    }
                    else if (command == "MachineReport")
                    {
                        result = this.machinesManager
                                .MachineReport(name);
                    }
                    else if (command == "AggressiveMode")
                    {
                        result = this.machinesManager
                                .ToggleFighterAggressiveMode(name);
                    }
                    else if (command == "DefenseMode")
                    {
                        result = this.machinesManager
                                .ToggleTankDefenseMode(name);
                    }
                    else if (command == "Engage")
                    {
                        string machineName = tokens[2];

                        result = this.machinesManager
                            .EngageMachine(name, machineName);
                    }
                    else if (command == "Attack")
                    {
                        string defendingMachineName = tokens[2];

                        result = this.machinesManager
                            .AttackMachines(name, defendingMachineName);
                    }

                    this.writer.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                input = this.reader.ReadCommands();
            }
        }
    }
}