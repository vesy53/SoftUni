namespace p04._01.FirstAndReserveTeam.Core
{
    using System;

    public class Engine
    {
        public void Run()
        {
            int number = int.Parse(Console.ReadLine());

            Team team = new Team("Levski");

            for (int i = 0; i < number; i++)
            {
                try
                {
                    string[] tokens = Console.ReadLine()
                        .Split(" ",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string firstName = tokens[0];
                    string lastName = tokens[1];
                    int age = int.Parse(tokens[2]);
                    decimal salary = decimal.Parse(tokens[3]);

                    Person person = new Person(
                        firstName,
                        lastName,
                        age,
                        salary);

                    team.AddPlayer(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(team);
        }
    }
}
