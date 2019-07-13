namespace p10._01.ExplicitInterfaces.Core
{
    using System;

    using IO.Contracts;
    using p10._01.ExplicitInterfaces.Contracts;
    using p10._01.ExplicitInterfaces.Models;

    public class Engine
    {
        private IReader reader;

        public Engine(IReader reader)
        {
            this.reader = reader;
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

                string name = tokens[0];
                string country = tokens[1];
                int age = int.Parse(tokens[2]);

                Citizen citizen = new Citizen(
                    name,
                    country,
                    age);

                IPerson person = citizen;
                IResident resident = citizen;

                person.GetName();
                resident.GetName();

                input = Console.ReadLine();
            }
        }
    }
}
