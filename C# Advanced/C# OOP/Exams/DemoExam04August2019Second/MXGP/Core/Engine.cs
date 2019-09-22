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
        private readonly IChampionshipController championship;

        public Engine()
        {
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
            this.championship = new ChampionshipController();
        }

        public void Run()
        {
            string input = reader.ReadLine();

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
                            result = this.championship
                                .CreateRider(name);
                            break;
                        case "CreateMotorcycle":
                            string type = name;
                            string model = tokens[2];
                            int horsepower = int.Parse(tokens[3]);

                            result = this.championship
                               .CreateMotorcycle(type, model, horsepower);
                            break;
                        case "AddMotorcycleToRider":
                            string motorcycleName = tokens[2];

                            result = this.championship
                               .AddMotorcycleToRider(name, motorcycleName);
                            break;
                        case "AddRiderToRace":
                            string riderName = tokens[2];

                            result = this.championship
                               .AddRiderToRace(name, riderName);
                            break;
                        case "CreateRace":
                            int laps = int.Parse(tokens[2]);

                            result = this.championship
                               .CreateRace(name, laps);
                            break;
                        case "StartRace":
                            result = this.championship
                               .StartRace(name);
                            break;
                    }

                    writer.WriteLine(result);
                }
                catch (Exception e)
                {
                    writer.WriteLine(e.Message);
                }

                input = reader.ReadLine();
            }
        }
    }
}
