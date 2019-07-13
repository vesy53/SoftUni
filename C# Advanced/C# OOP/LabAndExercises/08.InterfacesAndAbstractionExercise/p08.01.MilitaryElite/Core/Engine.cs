namespace p08._01.MilitaryElite.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using IO.Contracts;
    using p08._01.MilitaryElite.Contracts;
    using p08._01.MilitaryElite.Models;

    public class Engine
    {
        private IReader reader;
        private IWriter writer;
        private readonly List<ISoldier> soldiers;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;

            this.soldiers = new List<ISoldier>();
        }

        public void Run()
        {
            string input = reader.ConsoleReadLine();

            while (input.Equals("End") == false)
            {
                string[] tokens = input
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string type = tokens[0];
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];
                decimal salary = decimal.Parse(tokens[4]);

                if (type == "Private")
                {
                    Private soldier = new Private(id, firstName, lastName, salary);

                    this.soldiers.Add(soldier);
                }
                else if (type == "LieutenantGeneral")
                {
                    LieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < tokens.Length; i++)
                    {
                        int privateId = int.Parse(tokens[i]);

                        IPrivate privateSoldier = (IPrivate)this.soldiers
                            .FirstOrDefault(x => x.Id == privateId);

                        general.AddPrivate(privateSoldier);
                    }

                    this.soldiers.Add(general);
                }
                else if (type == "Engineer")
                {
                    try
                    {
                        string corps = tokens[5];

                        IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                        for (int i = 6; i < tokens.Length; i += 2)
                        {
                            string partName = tokens[i];
                            int workedHours = int.Parse(tokens[i + 1]);

                            IRepair repair = new Repair(partName, workedHours);

                            engineer.AddRepair(repair);
                        }

                        this.soldiers.Add(engineer);
                    }
                    catch (ArgumentException ae)
                    {
                    }
                }
                else if (type == "Commando")
                {
                    try
                    {
                        string corps = tokens[5];

                        ICommando commando = new Commando(id, firstName, lastName, salary, corps);

                        for (int i = 6; i < tokens.Length; i += 2)
                        {
                            try
                            {
                                string codeName = tokens[i];
                                string state = tokens[i + 1];

                                IMission mission = new Mission(codeName, state);

                                commando.AddMission(mission);
                            }
                            catch (ArgumentException ae)
                            {
                                continue;
                            }
                        }

                        this.soldiers.Add(commando);
                    }
                    catch (ArgumentException ae)
                    {
                    }
                }
                else if (type == "Spy")
                {
                    int codeNumber = (int)salary;

                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);

                    this.soldiers.Add(spy);
                }

                input = Console.ReadLine();
            }

            foreach (ISoldier soldier in soldiers)
            {
                writer.ConsoleWriteLine(soldier);
            }
        }
    }
}