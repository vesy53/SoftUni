using MXGP.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Core
{
    public class Engine : IEngine
    {
        public IChampionshipController controller;

        public Engine()
        {
            this.controller = new ChampionshipController();
        }

        public void Run()
        {
            string input = Console.ReadLine();

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
                            result = this.controller
                                .CreateRider(name);
                            break;
                        case "CreateMotorcycle":
                            string model = tokens[2];
                            int horsePower = int.Parse(tokens[3]);

                            result = this.controller
                                .CreateMotorcycle(name, model, horsePower);
                            break;
                        case "AddMotorcycleToRider":
                            string motoName = tokens[2];

                            result = this.controller
                                .AddMotorcycleToRider(name, motoName);
                            break;
                        case "AddRiderToRace":
                            string riderName = tokens[2];

                            result = this.controller
                                .AddRiderToRace(name, riderName);
                            break;
                        case "CreateRace":
                            int laps = int.Parse(tokens[2]);

                            result = this.controller
                                .CreateRace(name, laps);
                            break;
                        case "StartRace":
                            result = this.controller
                                .StartRace(name);
                            break;
                    }

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

        }
    }
}
