namespace MXGP.Core
{
    using System;

    using MXGP.Core.Contracts;
    using MXGP.IO;
    using MXGP.IO.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IChampionshipController controller;

        public Engine()
        {
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();

            this.controller = new ChampionshipController();
        }

        public void Run()
        {
            string input = this.reader.ReadLine();

            while (input.Equals("End") == false)
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
                        case "CreateRider":
                            result = this.controller.CreateRider(name);
                            break;
                        case "CreateMotorcycle":
                            string model = tokens[2];
                            int horsepower = int.Parse(tokens[3]);

                            result = this.controller
                                .CreateMotorcycle(name, model, horsepower);
                            break;
                        case "AddMotorcycleToRider":
                            string motorcycleName = tokens[2];

                            result = this.controller
                                .AddMotorcycleToRider(name, motorcycleName);
                            break;
                        case "AddRiderToRace":
                            string riderName = tokens[2];

                            result = this.controller
                                .AddRiderToRace(name, riderName);
                            break;
                        case "CreateRace":
                            int laps= int.Parse(tokens[2]);

                            result = this.controller
                                .CreateRace(name, laps);
                            break;
                        case "StartRace":
                            result = this.controller
                                .StartRace(name);
                            break;
                    }

                    this.writer.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                input = this.reader.ReadLine();
            }
        }
    }
}
